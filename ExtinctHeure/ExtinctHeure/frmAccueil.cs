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
using ExtinctHeureUC;
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
        DataSet monDS = MesDatas.DsGlobal;
        bool loaded = false;

        private void load()
        {
            loaded = true;
            DataTable SchemaTable = cx.GetSchema("Tables");
            foreach (DataRow row in SchemaTable.Rows)
            {
                String requete = "SELECT * FROM " + row["TABLE_NAME"].ToString();
                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(monDS, row["TABLE_NAME"].ToString());
            }
            Connexion.FermerConnexion();

            DataRelation relCaserne = new DataRelation("FK_Mission_idCaserne", monDS.Tables["Caserne"].Columns["id"], monDS.Tables["Mission"].Columns["idCaserne"], false);
            DataRelation relNature = new DataRelation("FK_Mission_idNature", monDS.Tables["NatureSinistre"].Columns["id"], monDS.Tables["Mission"].Columns["idNatureSinistre"], false);

            monDS.Relations.Add(relCaserne);
            monDS.Relations.Add(relNature);
        }

        private void grpMissions_VisibleChanged(object sender, EventArgs e)
        {
            if (!loaded) { load(); }
            int position = 30; // + 160
            pnlMissions.Controls.Clear();
            foreach (DataRow dataRow in monDS.Tables["Mission"].Rows)
            {
                Mission mission = new Mission();
                mission.idMission = Convert.ToInt32(dataRow["id"]);
                mission.debutMission = dataRow["dateHeureDepart"].ToString();
                mission.caserne = dataRow.GetParentRow("FK_Mission_idCaserne")["nom"].ToString();
                mission.natureMission = dataRow.GetParentRow("FK_Mission_idNature")["libelle"].ToString();
                mission.nomMission = dataRow["motifAppel"].ToString();
                mission.estFini = dataRow["dateHeureRetour"] != typeof(DBNull);

                if (chkEnCours.Checked && !mission.estFini)
                {
                    mission.Location = new Point(7, position);
                    position += mission.Height + 10;

                    pnlMissions.Controls.Add(mission);
                }
                else if (!chkEnCours.Checked)
                {
                    mission.Location = new Point(7, position);
                    position += mission.Height + 10;

                    pnlMissions.Controls.Add(mission);
                }
                pnlMissions.Size = new Size(1204, 601);

            }
        }
    }
}
