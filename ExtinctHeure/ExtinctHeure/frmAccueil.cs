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

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            DataTable SchemaTable = cx.GetSchema("Tables");
            foreach (DataRow row in SchemaTable.Rows)
            {
                String requete = "SELECT * FROM " + row["TABLE_NAME"].ToString();
                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(monDS, row["TABLE_NAME"].ToString());
            }
            Connexion.FermerConnexion();

            ForeignKeyConstraint FK_Mission_idCaserne = new ForeignKeyConstraint("FK_Mission_idCaserne", monDS.Tables["Caserne"].Columns["id"], monDS.Tables["Mission"].Columns["idCaserne"]);
            ForeignKeyConstraint FK_Mission_idNature = new ForeignKeyConstraint("FK_Mission_idNature", monDS.Tables["NatureSinistre"].Columns["id"], monDS.Tables["Mission"].Columns["idNatureSinistre"]);

            monDS.Tables["Mission"].Constraints.Add(FK_Mission_idCaserne);
            monDS.Tables["Mission"].Constraints.Add(FK_Mission_idNature);
        }

        private void grpMissions_VisibleChanged(object sender, EventArgs e)
        {
            int position = 30; // + 160
            foreach (DataRow dataRow in monDS.Tables["Mission"].Rows)
            {
                Mission mission = new Mission();
                mission.idMission = Convert.ToInt32(dataRow["id"]);
                mission.debutMission = dataRow["dateMission"].ToString();
                mission.caserne = dataRow.GetParentRow("FK_Mission_idCaserne")["id"].ToString();
                mission.natureMission = dataRow.GetParentRow("FK_Mission_idNature")["id"].ToString();
                mission.nomMission = dataRow["motifAppel"].ToString();

                mission.Location = new Point(7, position);
                position += 160;

                grpMissions.Controls.Add(mission);
            }
        }
    }
}
