using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Pinpon;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ExtinctHeure
{
    public partial class frmAjoutPompier : Form
    {
        private string sexe = "";
        private string type = "";
        private readonly SQLiteConnection _cx;
        public frmAjoutPompier()
        {
            InitializeComponent();

            calDateNaissance.MaxDate = DateTime.Today.AddYears(-16).AddDays(1);

            try
            {
                this._cx = Connexion.Connec;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de l'accès à la DB : " + ex.Message);
            }
        }

        private void frmAjoutPompier_Load(object sender, EventArgs e)
        {
            ChargercboCasernes();
            ChargerCboGrades();
            ChargerLstHabilitations();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

            if (fieldsCheck())
            {
                SQLiteTransaction transactionPompier = _cx.BeginTransaction();

                // On manipules les chaines de charactères pour avoir la première lettre en majuscule et le reste en minuscule
                string nom = txtNom.Text.Substring(0, 1).ToUpper() + txtNom.Text.Substring(1, txtNom.Text.Length - 1).ToLower();
                string prenom = txtPrenom.Text.Substring(0, 1).ToUpper() + txtPrenom.Text.Substring(1, txtPrenom.Text.Length - 1).ToLower();

                string dateNaissance = calDateNaissance.SelectionRange.Start.ToString("yyyy-MM-dd");
                string codeGrade = cboGrades.SelectedValue.ToString();
                string telephone = txtTelephone.Text;
                string dateEmbauche = DateTime.Today.ToString("yyyy-MM-dd");
                int matricule = getMaxMatricule() + 1;
                int bip = matricule;

                string req = "INSERT INTO Pompier (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche) " +
                                   $"VALUES ({matricule}, '{nom}', '{prenom}', '{sexe}', '{dateNaissance}', '{type}', '{telephone}', {bip}, {0}, {0}, '{codeGrade}', '{dateEmbauche}')";

                SQLiteCommand cmdUpdatePompier = new SQLiteCommand(req, this._cx, transactionPompier);

                try
                {
                    cmdUpdatePompier.ExecuteNonQuery();
                    transactionPompier.Commit();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    transactionPompier.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }

                // On insère les habilitations du pompier dans la table Passer
                SQLiteTransaction transactionPasser = _cx.BeginTransaction();
                SQLiteCommand cmdUpdatePasser = new SQLiteCommand(_cx);
                cmdUpdatePasser.Transaction = transactionPasser;

                for (int i = 0; i < chklstHabilitations.CheckedItems.Count; i++)
                {
                    string habilitation = chklstHabilitations.CheckedItems[i].ToString();
                    if (habilitation.Contains("'"))
                    {
                        habilitation = habilitation.Replace("'", "''");
                    }
                    req = "INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention)" +
                         $"VALUES ({matricule},(SELECT id FROM Habilitation WHERE libelle = '{habilitation}'), '{DateTime.Today.ToString("yyyy-MM-dd")}')";
                    cmdUpdatePasser.CommandText = req;
                    try
                    { 
                        cmdUpdatePasser.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Erreur lors de l'insertion des habilitations : " + ex.Message);
                        return;
                    }
                }
                try
                {
                    transactionPasser.Commit();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    transactionPasser.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }

                SQLiteTransaction transactionCaserne = _cx.BeginTransaction();
                req = $@"INSERT INTO Affectation(matriculePompier, dateA, idCaserne)
                      VALUES({matricule}, '{DateTime.Today:yyyy-MM-dd}', {cboCasernes.SelectedValue})";
                SQLiteCommand cmdUpdateCaserne = new SQLiteCommand(req, this._cx, transactionCaserne);

                try
                {
                    transactionCaserne.Commit();
                    cmdUpdateCaserne.ExecuteNonQuery();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    transactionCaserne.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) { e.Handled = false; }
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((char.IsDigit(e.KeyChar) && txtTelephone.TextLength < 10) || char.IsControl(e.KeyChar)) { e.Handled = false; }
        }

        private void ChargercboCasernes()
        {
            string req = "SELECT nom, id AS idCaserne FROM Caserne";

            SQLiteDataAdapter daCaserne = new SQLiteDataAdapter(req, this._cx);
            DataTable dtCasernes = new DataTable();

            daCaserne.Fill(dtCasernes);
            cboCasernes.ValueMember = "idCaserne"; // Valeur de la combobox est l'id de la caserne
            cboCasernes.DisplayMember = "nom"; // Affichage du nom de la caserne dans la combobox
            cboCasernes.DataSource = dtCasernes;
            cboCasernes.SelectedIndex = -1; // On ne sélectionne rien par défaut
        }

        private void ChargerCboGrades()
        {
            string req = "SELECT libelle, code FROM Grade";

            SQLiteDataAdapter daGrade = new SQLiteDataAdapter(req, this._cx);
            DataTable dtGrade = new DataTable();

            daGrade.Fill(dtGrade);
            cboGrades.ValueMember = "code"; // Valeur de la combobox est l'id de la caserne
            cboGrades.DisplayMember = "libelle"; // Affichage du nom de la caserne dans la combobox
            cboGrades.DataSource = dtGrade;
            cboGrades.SelectedIndex = -1; // On ne sélectionne rien par défaut
        }

        private void ChargerLstHabilitations()
        {
            string req = "SELECT libelle FROM Habilitation";
            SQLiteCommand cmd = new SQLiteCommand(req, this._cx);
            SQLiteDataReader habilitationReader = cmd.ExecuteReader();

            while (habilitationReader.Read())
            {
                string nomHabilitation = habilitationReader.GetString(0);
                this.chklstHabilitations.Items.Add(nomHabilitation);
            }
        }

        private bool fieldsCheck()
        {
            TextBox[] textBoxes = { txtNom, txtPrenom, txtTelephone};
            ComboBox[] comboBoxes = { cboCasernes, cboGrades };
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider.Clear();
                    errorProvider.SetError(textBox, "Veuillez remplir ce champ avant de confirmer !");
                    return false;
                }
            }

            if (!rdbHomme.Checked && !rdbFemme.Checked)
            {
                errorProvider.Clear();
                errorProvider.SetError(rdbFemme, "Veuillez sélectionner un sexe avant de confirmer !");
                return false;
            }

            if (calDateNaissance.SelectionRange.Start == calDateNaissance.MaxDate ||
                calDateNaissance.SelectionRange.End == calDateNaissance.MaxDate)
            {
                errorProvider.Clear();
                errorProvider.SetError(calDateNaissance, "Veuillez sélectionner une date de naissance valide avant de confirmer !");
                return false;
            }

            if (!rdbProfessionnel.Checked && !rdbVolontaire.Checked)
            {
                errorProvider.Clear();
                errorProvider.SetError(rdbVolontaire, "Veuillez sélectionner un statut avant de confirmer !");
                return false;
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.Text == String.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(comboBox, "Veuillez sélectionner une option avant de confirmer !");
                    errorProvider.SetIconAlignment(comboBox, ErrorIconAlignment.MiddleRight);
                    return false;
                }
            }

            if (chklstHabilitations.CheckedIndices.Count < 1)
            {
                errorProvider.Clear();
                errorProvider.SetError(chklstHabilitations, "Veuillez sélectionner au moins une habilitation avant de confirmer !");
                return false;
            }

            if (rdbHomme.Checked)
            {
                sexe = "m";
            }
            else
            {
                sexe = "f";
            }

            if (rdbProfessionnel.Checked)
            {
                type = "p";
            }
            else
            {
                type = "v";
            }
            return true;
        }
        private int getMaxMatricule()
        {
            int matricule = 0;
            string req = "SELECT max(matricule) FROM Pompier";
            SQLiteCommand cmd = new SQLiteCommand(req, this._cx);
            SQLiteDataReader matriculeReader = cmd.ExecuteReader();

            while (matriculeReader.Read())
            {
                matricule = matriculeReader.GetInt32(0);
            }
            return matricule;
        }

        private void cboGrades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pcbGrade.ImageLocation = $@"..\..\..\..\Ressources\ImagesGrades\{cboGrades.SelectedValue.ToString()}.png";
            pcbGrade.Load();
        }

        private void rdbProfessionnel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProfessionnel.Checked)
            {
                pcbTypePompier.ImageLocation = @"..\..\..\..\Ressources\imagesPompiers\icone-pompier-noir-blanc.png";
                pcbTypePompier.Load();
            }
            else if (rdbVolontaire.Checked)
            {
                pcbTypePompier.ImageLocation = @"..\..\..\..\Ressources\imagesPompiers\icone-pompier-blanc.png";
                pcbTypePompier.Load();
            }
        }
    }
}
