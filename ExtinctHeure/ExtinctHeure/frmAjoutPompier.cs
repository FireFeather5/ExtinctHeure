using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (!fieldsCheck())
            {
                MessageBox.Show("Une erreur a eu lieu lors de la création");
            }
            else
            {
                SQLiteTransaction transaction = cx.BeginTransaction();

                // On manipules les chaines de charactères pour avoir la première lettre en majuscule et le reste en minuscule
                string nom = txtNom.Text.Substring(0, 1).ToUpper() +
                             txtNom.Text.Substring(1, txtNom.Text.Length - 1).ToLower();
                string prenom = txtPrenom.Text.Substring(0, 1).ToUpper() +
                                 txtPrenom.Text.Substring(1, txtPrenom.Text.Length - 1).ToLower();
                string sexe = _strBuffer[0];
                string type = _strBuffer[1];
                string dateNaissance = calDateNaissance.SelectionRange.Start.ToString("yyyy-MM-dd");

                // A MODIFIER

                /*string req = "INSERT INTO Pompier (nom, prenom, sexe, dateNaissance, type, portable, idCaserne, idGrade) " +
                             $"VALUES ('{nom}', '{prenom}', '{sexe}', '{dateNaissance}', '{type}', '{txtTelephone.Text}', @idCaserne, @idGrade)";*/
                
                DialogResult = DialogResult.OK;
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
            string req = "SELECT libelle FROM Grade";
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
                _strBuffer[0] = rdbHomme.Text;
            }
            else
            {
                _strBuffer[0] = rdbFemme.Text;
            }

            if (rdbProfessionnel.Checked)
            {
                _strBuffer[1] = rdbProfessionnel.Text;
            }
            else
            {
                _strBuffer[1] = rdbVolontaire.Text;
            }
            return true;
        }
    }
}
