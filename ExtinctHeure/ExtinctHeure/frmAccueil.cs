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
            ArrayList Vehicule = new ArrayList();   //type de vehicule necessaire
            ArrayList NbrVehi = new ArrayList();    //nombre de chaque type de vehicule nece
            ArrayList validate = new ArrayList();   //est ce que le vehicule est disponible

            dgvEng.Columns.Clear();

            dgvEng.Columns.Add("Engin", "Engin");
            dgvEng.Columns.Add("Nombre", "Nombre");

            int idSin = cboNatSin.SelectedIndex + 1;
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Necessiter"].Rows)
            {
                if (Convert.ToInt32(dr["idNatureSinistre"]) == idSin)
                {
                    Vehicule.Add(dr["codeTypeEngin"]);
                    NbrVehi.Add(dr["nombre"]);

                    //dgvEng.Rows.Add(dr["codeTypeEngin"], dr["nombre"]);
                }
            }


            // pour chaque rows -> teste si caserne ok
            // si ok -> prend array list vehicule
            // si vehicule et codetype pareils
            // si le vehicule est libre
            // mettre dans une nouvelle array list finale
            // qui contient tout ce qui est valide
            // et apres je sais pas

            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Engin"].Rows)
            {
                if (Convert.ToInt32(dr["idCaserne"]) == cboCasMob.SelectedIndex + 1)      //si la caserne est la meme
                {
                    
                    int truuuc = 0;         //sert d'indexeur à NbrVehi
                    foreach(string Eng in Vehicule)     //pour chaque engin necessaire
                    {
                        int truc = 0;      //sert à tester si il y a le bon nombre d'engin disponibles
                        bool val = false;   //est ce que le vehicule est disponible

                        if (Eng == dr["codeTypeEngin"].ToString())      //si le code engin est le meme
                        {


                            if ((Convert.ToInt32(dr["enMission"]) == 0) && (Convert.ToInt32(dr["enPanne"]) == 0))       //si l'engin est disponible
                            {
                                truc++;         //incrémente si disponible
                            }

                            
                        }

                        if (truc >= Convert.ToInt32(NbrVehi[truuuc]))       //si il y a assez d'engins dispo
                        {
                            val = true;     //on valide l'engin

                            MessageBox.Show("valide");
                        }
                        else
                        {
                            // le false fait planter le programme il faut trouver un moyen de
                            // dire si un engin est valide ou non sans que cela affecte le type
                            // d'engin complet
                            MessageBox.Show("non valide");
                        }

                        truuuc++;       //incrémentation de l'indexeur
                    }
                }
            }

            bool te = true;         // sert à vérifier que tous les engins sont dispo en nbr suffisant
            foreach (bool val in validate)
            {
                if (!val)           // si engin pas validé
                {
                    te = false;
                    MessageBox.Show("certains Engins ne sont pas disponibles, choisissez une autre caserne.");
                }
            }

            if (te)         //si tout est bon
            {
                int z = 0;      // indexeur
                foreach (string vehi in Vehicule)       //ajout dans le dgv
                {
                    dgvEng.Rows.Add(vehi, NbrVehi[z]);
                    z++;
                }
            }


        }

        //Pour trouver le bon véhicule à emmener :
        //cboTag id (nature sinistre) -> codetype et nombre (necessiter)
        //-> id caserne, numero, enmission et enpanne (engin)




    }
}
