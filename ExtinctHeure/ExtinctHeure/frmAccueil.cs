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
using ExtinctHeureUC;

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

            cboCaserneStat.SelectedIndex = 0;
            statsInterventionSinistre.Clear();
            requete = "select ns.libelle, count(*) from Mission m join NatureSinistre ns on m.idNatureSinistre = ns.id group by idNatureSinistre order by count(*) desc";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                int nbIntervention = reader.GetInt32(1);
                statsInterventionSinistre.AjouterLigne(nom, nbIntervention.ToString());
            }

            requete = "select libelle from Habilitation";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                cboHabilitation.Items.Add(nom);
            }

            cboHabilitation.SelectedIndex = 0;

            statsHabilitationDemandee.Clear();
            requete = "select h.libelle, count(*) from Mobiliser m join Habilitation h on m.idHabilitation = h.id group by m.idHabilitation order by count(*) desc";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                int nbDemande = reader.GetInt32(1);
                statsHabilitationDemandee.AjouterLigne(nom, nbDemande.ToString());
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
            statsEnginPlusUtilise.Clear();
            while (reader.Read())
            {
                String nom = reader.GetString(0);
                int nbUtilisation = reader.GetInt32(1);
                statsEnginPlusUtilise.AjouterLigne(nom, nbUtilisation.ToString());
            }

            requete = $"select pa.codeTypeEngin || pa.numeroEngin \"Engin\", cast(printf(\"%.2f\", sum((julianday(m.dateHeureRetour) - julianday(m.dateHeureDepart))*24)) as NUMERIC) \"temps passé\" from Mission m join PartirAvec pa on m.id = pa.idMission where pa.idCaserne = {cboCaserneStat.SelectedIndex + 1} group by Engin order by \"temps passé\" desc";
            cmd = new SQLiteCommand(requete, cx);
            reader = cmd.ExecuteReader();
            statsEnginPlusUtiliseHeure.Clear();
            while (reader.Read())
            {
                float nbHeure;
                if (reader.IsDBNull(1))
                {
                    nbHeure = 0;
                }
                else
                {
                    nbHeure = reader.GetFloat(1);
                }
                String nom = reader.GetString(0);
                statsEnginPlusUtiliseHeure.AjouterLigne(nom, nbHeure.ToString());
            }
        }

        private void cboHabilitation_SelectedIndexChanged(object sender, EventArgs e)
        {
            String requete = $"select h.libelle, pmp.prenom, pmp.nom from Passer p join Pompier pmp on p.matriculePompier = pmp.matricule join Habilitation h on p.idHabilitation = h.id where h.libelle = \"{cboHabilitation.SelectedItem.ToString()}\" order by h.id";
            SQLiteCommand cmd = new SQLiteCommand(requete, cx);
            SQLiteDataReader reader = cmd.ExecuteReader();
            statsPompierHabilitation.Clear();
            while (reader.Read())
            {
                String nom = reader.GetString(1);
                String prenom = reader.GetString(2);
                statsPompierHabilitation.AjouterLigne(prenom, nom);
            }
        }
    }
}
