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
using Pinpon;

namespace ExtinctHeure
{
    public partial class frmAccueil : Form
    {
        private SQLiteConnection cx;
        public frmAccueil()
        {
            InitializeComponent();
            try
            {
                this.cx = Connexion.Connec;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de l'accès à la DB : " + ex.Message);

            }
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            ChargercboCasernes();
            ChargercboPompiers();
        }

        private void btnPlusInfos_Click(object sender, EventArgs e)
        {
            btnPlusInfos.Visible = false;
            grpInfosCarriere.Visible = true;
        }
        private void cboPompiers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCasernes.Text != String.Empty && cboPompiers.Text != String.Empty)
            {
                ChargerInfosPompiers();
            }
        }


        // Chargement des casernes et pompiers dans les ComboBox
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

        private void ChargercboPompiers()
        {
            string req = "SELECT prenom, nom FROM Pompier";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader pompierReader = cmd.ExecuteReader();
            while (pompierReader.Read())
            {
                string nom = pompierReader.GetString(0);
                string prenom = pompierReader.GetString(1);
                this.cboPompiers.Items.Add(nom + " " + prenom);
            }
        }

        // Charger les infos des pompiers
        private void ChargerInfosPompiers()
        {
            string nom = cboPompiers.Text.Split(' ')[1];
            string prenom = cboPompiers.Text.Split(' ')[0];
            string req = $"SELECT * FROM Pompier WHERE initcap(prenom) = '{prenom}' AND initcap(nom) = '{nom}'";
            MessageBox.Show(req);
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader pompierReader = cmd.ExecuteReader();
            while (pompierReader.Read())
            {
                // Remplir les champs avec les données du pompier
                Label lbl = new Label();
                for (int i = 0; i < 2; i++)
                {
                    lbl.Text = pompierReader.GetString(i);
                }

                lbl.Top = 20;
                grpInfosPerso.Controls.Add(lbl);

                /*txtPrenom.Text = pompierReader.GetString(1);
                txtDateNaissance.Text = pompierReader.GetString(2);
                txtDateEmbauche.Text = pompierReader.GetString(3);
                txtGrade.Text = pompierReader.GetString(4);
                txtCaserne.Text = pompierReader.GetString(5);*/
            }
        }
    }
}
