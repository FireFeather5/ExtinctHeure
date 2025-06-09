using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Pinpon;

namespace ExtinctHeure
{
    public partial class frmConnexion : Form
    {
        private DataTable _dtAdminInfos;
        private readonly SQLiteConnection _cx;
        public frmConnexion()
        {
            InitializeComponent();
            try
            {
                this._cx = Connexion.Connec;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la DB : " + ex.Message);
            }
        }

        private void getAdminInfos()
        {
            string req = "SELECT id, login, mdp AS password FROM Admin";

            SQLiteDataAdapter da = new SQLiteDataAdapter(req, this._cx);
            _dtAdminInfos = new DataTable();
            da.Fill(_dtAdminInfos);
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            getAdminInfos();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            foreach (DataRow row in _dtAdminInfos.Rows)
            {
                if (row["login"].ToString() == txtLogin.Text && row["password"].ToString() == txtPassword.Text)
                {
                    // Si les identifiants sont corrects, on ouvre le formulaire principal
                    DialogResult = DialogResult.OK;
                    isValid = true;
                    break;
                }
            }
            if (!isValid)
            {
                // Si les identifiants sont incorrects, on affiche un message d'erreur
                MessageBox.Show("Login et/ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) { e.Handled = false; }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar)) { e.Handled = false; }
        }
    }
}
