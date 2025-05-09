using System;
using System.Collections;
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

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            SQLiteConnection cx = Connexion.Connec;
            DataTable dt = cx.GetSchema("Tables");

            foreach (DataRow ligne in dt.Rows)
            {
                string requete = "select * from " + ligne[2];
                SQLiteCommand cd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cd);

                da.Fill(MesDatas.DsGlobal, ligne[2].ToString());
            }

            Connexion.FermerConnexion();


            lblDteMis.Text += " " + DateTime.Now.ToString();


            int i = 0;
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                if (i < Convert.ToInt32(dr["id"]))
                {
                    i = Convert.ToInt32(dr["id"]);
                }
            }
            i++;
            lblNumMis.Text += " " + i.ToString();


            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Caserne"].Rows)
            {
                int cas = Convert.ToInt32(dr["id"]);
                cboCasMob.Items.Add(cas);
            }

            int j = 1;
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
            {
                string lib = dr["libelle"].ToString();
                cboNatSin.Tag = j;
                j++;
                cboNatSin.Items.Add(lib);
            }
        }

        private void txtRue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((char.IsLetter(e.KeyChar)) || (char.IsNumber(e.KeyChar)))
            {
                e.Handled = false;
            }
            if ((e.KeyChar == (char)Keys.Tab) || (e.KeyChar == (char)Keys.Enter))
            {
                txtCP.Focus();
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                e.Handled = false;
            }
            if (txtCP.Text.Length < 2)
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
            if ((e.KeyChar == (char)Keys.Tab) || (e.KeyChar == (char)Keys.Enter))
            {
                txtVille.Focus();
            }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtMotif_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == (char)Keys.Tab) || (e.KeyChar == (char)Keys.Enter))
            {
                txtRue.Focus();
            }
        }

        private void btnConstEqu_Click(object sender, EventArgs e)
        {
            ArrayList Vehicule = new ArrayList();
            ArrayList NbrVehi = new ArrayList();

            int idSin = cboNatSin.SelectedIndex + 1;
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Necessiter"].Rows)
            {
                if (Convert.ToInt32(dr["idNatureSinistre"]) == idSin)
                {

                    Vehicule.Add(dr["codeTypeEngin"]);
                }
            }
        }

        //Pour trouver le bon véhicule à emmener :
        //cboTag id (nature sinistre) -> codetype et nombre (necessiter)
        //-> id caserne, numero, enmission et enpanne (engin)




    }
}
