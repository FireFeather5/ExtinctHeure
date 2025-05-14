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

            dgvInterventionSinistre.Columns.Add("Nom", "Nature du sinistre");
            dgvInterventionSinistre.Columns.Add("NbIntervention", "Nombre d'intervention");
            dgvInterventionSinistre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            requete = "select ns.libelle, count(*) from Mission m join NatureSinistre ns on m.idNatureSinistre = ns.id group by idNatureSinistre order by count(*) desc";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                int nbIntervention = reader.GetInt32(1);
                dgvInterventionSinistre.Rows.Add(nom, nbIntervention);
            }

            requete = "select libelle from Habilitation";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                cboHabilitation.Items.Add(nom);
            }

            dgvPompierHabilitation.Columns.Add("Prenom", "Prénom");
            dgvPompierHabilitation.Columns.Add("Nom", "Nom");
            dgvPompierHabilitation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboHabilitation.SelectedIndex = 0;

            dgvHabilitationDemandee.Columns.Add("Habilitation", "Habilitation");
            dgvHabilitationDemandee.Columns.Add("NbDemande", "Nombre de demande");
            dgvHabilitationDemandee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requete = "select h.libelle, count(*) from Mobiliser m join Habilitation h on m.idHabilitation = h.id group by m.idHabilitation order by count(*) desc";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                int nbDemande = reader.GetInt32(1);
                dgvHabilitationDemandee.Rows.Add(nom, nbDemande);
            }
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

            requete = $"select pa.codeTypeEngin || pa.numeroEngin \"Engin\", printf(\"%.2f\", sum((julianday(m.dateHeureRetour) - julianday(m.dateHeureDepart))*24)) \"temps passé\" from Mission m join PartirAvec pa on m.id = pa.idMission where pa.idCaserne = {cboCaserneStat.SelectedIndex + 1} group by Engin order by \"temps passé\" desc";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            dgvEnginPlusUtiliseHeure.Rows.Clear();
            while (reader.Read())
            {
                String nbHeure;
                if (reader.IsDBNull(1))
                {
                    nbHeure = "0";
                }
                else
                {
                    nbHeure = reader.GetString(1);
                }
                String nom = reader.GetString(0);
                dgvEnginPlusUtiliseHeure.Rows.Add(nom, nbHeure);
            }
        }

        private void cboHabilitation_SelectedIndexChanged(object sender, EventArgs e)
        {
            String requete = $"select h.libelle, pmp.prenom, pmp.nom from Passer p join Pompier pmp on p.matriculePompier = pmp.matricule join Habilitation h on p.idHabilitation = h.id where h.libelle = \"{cboHabilitation.SelectedItem.ToString()}\" order by h.id";
            SQLiteCommand cmd = new SQLiteCommand(requete, cx);
            SQLiteDataReader reader = cmd.ExecuteReader();
            dgvPompierHabilitation.Rows.Clear();
            while (reader.Read())
            {
                String nom = reader.GetString(1);
                String prenom = reader.GetString(2);
                dgvPompierHabilitation.Rows.Add(prenom, nom);
            }
        }
    }
}
