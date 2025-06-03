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

namespace ExtinctHeure
{
    public partial class frmAjoutPompier : Form
    {
        private string[] _strBuffer = new string[10];
        private int[] _intBuffer = new int[10];
        private SQLiteConnection cx;
        public frmAjoutPompier()
        {
            InitializeComponent();

            calDateNaissance.MaxDate = DateTime.Today.AddYears(-16).AddDays(1);

            try
            {
                this.cx = Connexion.Connec;
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
            MessageBox.Show(chklstHabilitations.SelectedItems.Count.ToString());

            if (fieldsCheck())
            {
                SQLiteTransaction transaction = cx.BeginTransaction();

                // On manipules les chaines de charactères pour avoir la première lettre en majuscule et le reste en minuscule
                string nom = txtNom.Text.Substring(0, 1).ToUpper() + txtNom.Text.Substring(1, txtNom.Text.Length - 1).ToLower();
                string prenom = txtPrenom.Text.Substring(0, 1).ToUpper() + txtPrenom.Text.Substring(1, txtPrenom.Text.Length - 1).ToLower();
                string sexe = _strBuffer[0];
                string type = _strBuffer[1];
                string dateNaissance = calDateNaissance.SelectionRange.Start.ToString("yyyy-MM-dd");
                string codeGrade = getCodeGrade();
                string dateEmbauche = DateTime.Today.ToString("yyyy-MM-dd");
                int matricule = getMatricule() + 1;
                int bip = matricule;
                MessageBox.Show(chklstHabilitations.SelectedItems.Count.ToString());

                // A MODIFIER

                string reqPompier = "INSERT INTO Pompier (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche) " +
                                   $"VALUES ({matricule}, '{nom}', '{prenom}', '{sexe}', '{dateNaissance}', '{type}', '{txtTelephone.Text}', {bip}, {0}, {0}, '{codeGrade}', '{dateEmbauche}')";
                string reqHabilitations = "";

                SQLiteCommand cmdUpdatePompier = new SQLiteCommand(reqPompier, this.cx, transaction);
                SQLiteCommand cmdUpdatePasser = new SQLiteCommand(reqHabilitations, this.cx, transaction);

                

                for (int i = 0; i < chklstHabilitations.SelectedItems.Count; i++)
                {
                    reqHabilitations = "INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention)" +
                                      $"VALUES ({matricule},(SELECT id FROM Habilitation WHERE libelle = {chklstHabilitations.SelectedItems[i].ToString()}), '{DateTime.Today.ToString("yyyy-MM-dd")}')";
                    MessageBox.Show(reqHabilitations);
                    cmdUpdatePasser.CommandText = reqHabilitations;
                }

                /*try
                {
                    cmdUpdatePompier.ExecuteNonQuery();
                    transaction.Commit();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }*/
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
            string req = "SELECT nom FROM Caserne";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader caserneReader = cmd.ExecuteReader();

            while (caserneReader.Read())
            {
                string nomCaserne = caserneReader.GetString(0);
                this.cboCasernes.Items.Add(nomCaserne);
            }
        }

        private void ChargerCboGrades()
        {
            string req = "SELECT libelle, code FROM Grade";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader gradesReader = cmd.ExecuteReader();

            while (gradesReader.Read())
            {
                string nomgrades = gradesReader.GetString(0);
                this.cboGrades.Items.Add(nomgrades);
            }
        }

        private void ChargerLstHabilitations()
        {
            string req = "SELECT libelle FROM Habilitation";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
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
                _strBuffer[0] = "m";
            }
            else
            {
                _strBuffer[0] = "f";
            }

            if (rdbProfessionnel.Checked)
            {
                _strBuffer[1] = "p";
            }
            else
            {
                _strBuffer[1] = "v";
            }
            return true;
        }

        private string getCodeGrade()
        {
            string code = "";
            string req = $"SELECT code FROM Grade WHERE lower(libelle) = '{cboGrades.Text.ToLower()}'";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader codeReader = cmd.ExecuteReader();

            while (codeReader.Read())
            {
                code = codeReader.GetString(0);
            }
            return code;
        }
        private int getMatricule()
        {
            int matricule = 0;
            string req = "SELECT max(matricule) FROM Pompier";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader matriculeReader = cmd.ExecuteReader();

            while (matriculeReader.Read())
            {
                matricule = matriculeReader.GetInt32(0);
            }
            return matricule;
        }
    }
}
