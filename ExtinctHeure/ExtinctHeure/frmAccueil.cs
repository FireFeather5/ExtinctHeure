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

namespace ExtinctHeure
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        DataSet monDS = MesDatas.DsGlobal;
        BindingSource bsEngin = new BindingSource();

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            lblNumeroEngin.Text = "";
            lblReceptionEngin.Text = "";

            SQLiteConnection cx = Connexion.Connec;
            DataTable SchemaTable = cx.GetSchema("Tables");
            foreach (DataRow row in SchemaTable.Rows)
            {
                string requete = "SELECT * FROM " + row["TABLE_NAME"].ToString();
                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(monDS, row["TABLE_NAME"].ToString());
            }
            Connexion.FermerConnexion();

            BindingSource bsCaserne = new BindingSource();
            bsCaserne.DataSource = monDS.Tables["Caserne"];
            cboCaserne.DataSource = bsCaserne;
            cboCaserne.DisplayMember = "nom";

            monDS.Relations.Add("Caserne_Engin", monDS.Tables["Caserne"].Columns["id"], monDS.Tables["Engin"].Columns["idCaserne"]);

            bsEngin.DataSource = bsCaserne;
            bsEngin.DataMember = "Caserne_Engin";


            DataColumn idcomplet = new DataColumn("idComplet", typeof(string), "idCaserne + '-' + codeTypeEngin + '-' + numero");
            monDS.Tables["Engin"].Columns.Add(idcomplet);

            DataColumn image = new DataColumn("image", typeof(string), "'..\\..\\..\\..\\Ressources\\ImagesCamions\\' + codeTypeEngin + '.jpg'");
            monDS.Tables["Engin"].Columns.Add(image);


            lblNumeroEngin.DataBindings.Add("Text", bsEngin, "idComplet");
            lblReceptionEngin.DataBindings.Add("Text", bsEngin, "dateReception");
            chkMission.DataBindings.Add("Checked", bsEngin, "enMission");
            chkReparation.DataBindings.Add("Checked", bsEngin, "enPanne");
            pcbEngin.DataBindings.Add("ImageLocation", bsEngin, "image");
        }

        private void changerEngin(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                switch (btn.Name)
                {
                    case "btnPrevious":
                        bsEngin.MovePrevious();
                        break;
                    case "btnNext":
                        bsEngin.MoveNext();
                        break;
                    case "btnFirst":
                        bsEngin.MoveFirst();
                        break;
                    case "btnLast":
                        bsEngin.MoveLast();
                        break;
                }
            }
        }
    }
}
