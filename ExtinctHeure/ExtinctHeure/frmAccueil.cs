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
        public frmAccueil()
        {
            InitializeComponent();
        }

        SQLiteConnection cx = Connexion.Connec;

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            String requete = "SELECT nom FROM Caserne";
            SQLiteCommand cmd = new SQLiteCommand(requete, cx);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                cboCaserneStat.Items.Add(nom);
            }
            dgvEnginPlusUtilise.Columns.Add("Nom", "Nom de l'engin");
            dgvEnginPlusUtilise.Columns.Add("NbUtilisation", "Nombre d'utilisation");
            dgvEnginPlusUtiliseHeure.Columns.Add("Nom", "Nom de l'engin");
            dgvEnginPlusUtiliseHeure.Columns.Add("NbHeure", "Nombre d'heures");

            dgvEnginPlusUtilise.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnginPlusUtiliseHeure.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboCaserneStat.SelectedIndex = 0;
        }

        private void grpStat_VisibleChanged(object sender, EventArgs e)
        {
            if (grpStat.Visible)
            {

            }
        }

        private void cboCaserneStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            String requete = $"select codeTypeEngin || numeroEngin, count(*) from PartirAvec where idCaserne = {cboCaserneStat.SelectedIndex + 1} group by codeTypeEngin, numeroEngin order by count(*) desc";
            SQLiteCommand cmd = new SQLiteCommand(requete, cx);
            SQLiteDataReader reader = cmd.ExecuteReader();
            dgvEnginPlusUtilise.Rows.Clear();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                int nbUtilisation = reader.GetInt32(1);
                dgvEnginPlusUtilise.Rows.Add(nom, nbUtilisation);
            }

            requete = $"select pa.codeTypeEngin || pa.numeroEngin \"Engin\", sum(round((julianday(m.dateHeureRetour) - julianday(m.dateHeureDepart))*24)) \"temps passé\" from Mission m join PartirAvec pa on m.id = pa.idMission where pa.idCaserne = {cboCaserneStat.SelectedIndex + 1} group by Engin order by \"temps passé\" desc";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            dgvEnginPlusUtiliseHeure.Rows.Clear();
            while (reader.Read())
            {
                int nbHeure;
                if (reader.IsDBNull(1))
                {
                    nbHeure = 0;
                }
                else
                {
                    nbHeure = Convert.ToInt32(reader.GetFloat(1));
                }
                String nom = reader.GetString(0);
                dgvEnginPlusUtiliseHeure.Rows.Add(nom, nbHeure);
            }
        }
    }
}
