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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.draw;

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

        Dictionary<string, string> imageMission = new Dictionary<string, string>()
        {
            {"Secours d'urgence aux personnes", "SUAP.jpg" },
            {"Accident de la circulation", "AC.jpg" },
            {"Incendie", "Incendie.jpg" },
            {"Risque industriel et pollution", "RIP.jpg" },
            {"Feu de forêt", "FeuForet.jpg" },
            {"Protection de la faune", "PF.jpg" },
            {"Plan d'urgence", "PU.jpg" },
            {"Secours en mer ou rivière", "SMR.jpg" },
            {"Eboulement", "Eboulement.jpg" },
            {"Assistance non urgente", "ANU.jpg" }
        };

        private void grpMissions_VisibleChanged(object sender, EventArgs e)
        {
            if (!loaded) { load(); }
            int position = 0;
            pnlMissions.Controls.Clear();
            foreach (DataRow dataRow in monDS.Tables["Mission"].Rows)
            {
                Mission mission = new Mission();
                mission.idMission = Convert.ToInt32(dataRow["id"]);
                mission.debutMission = dataRow["dateHeureDepart"].ToString();
                mission.caserne = dataRow.GetParentRow("FK_Mission_idCaserne")["nom"].ToString();
                mission.natureMission = dataRow.GetParentRow("FK_Mission_idNature")["libelle"].ToString();
                mission.nomMission = dataRow["motifAppel"].ToString();
                mission.adresseMission = dataRow["adresse"].ToString();
                mission.rapportMission = dataRow["compteRendu"].ToString();
                mission.imageMission = System.Drawing.Image.FromFile("../../../../Ressources/ImageMission/" + imageMission[mission.natureMission]);
                mission.estFini = !(dataRow["dateHeureRetour"] is DBNull);
                if (mission.estFini)
                {
                    mission.finMission = dataRow["dateHeureRetour"].ToString();
                }

                mission.CreerRapportEvent += genererRapport;

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
            }
            pnlMissions.Size = new Size(1204, 601);
        }

        iTextSharp.text.Font h1 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
        iTextSharp.text.Font h2 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);


        private void genererRapport(object sender, EventArgs e)
        {
            Mission mission = (Mission)sender;

            String path = $"../../../../Rapports/Rapport_mission_{mission.idMission}.pdf";
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            Paragraph titre = new Paragraph("Rapport de mission " + mission.idMission, h1);
            titre.Alignment = Element.ALIGN_CENTER;
            doc.Add(titre);
             
            doc.Add(new Chunk(new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, 10)));

            doc.Add(new Paragraph("Date de début : " + mission.debutMission));
            doc.Add(new Paragraph("Date de fin : " + mission.finMission));

            doc.Add(new Chunk(new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, 4)));

            doc.Add(new Paragraph("Nature de la mission : " + mission.natureMission, h2));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Nom de la mission : " + mission.nomMission));
            doc.Add(new Paragraph("Adresse : " + mission.adresseMission));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Compte-rendu : " + mission.rapportMission));

            doc.Add(new Chunk(new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, 4)));

            doc.Add(new Paragraph("Caserne : " + mission.caserne, h2));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Pompiers affectés : ", h2));
            for (int i = 0; i < monDS.Tables["Moiliser"].Rows.Count; i++)   
            {
                if (monDS.Tables["Moiliser"].Rows[i]["idMission"].ToString() == mission.idMission.ToString())
                {
                    DataRow[] rows = monDS.Tables["Pompiers"].Select("id = " + monDS.Tables["Moiliser"].Rows[i]["idPompier"].ToString());
                    if (rows.Length > 0)
                    {
                        doc.Add(new Paragraph(rows[0]["nom"].ToString() + " " + rows[0]["prenom"].ToString()));
                    }
                }
            }


            doc.Close();
        }
    }
}
