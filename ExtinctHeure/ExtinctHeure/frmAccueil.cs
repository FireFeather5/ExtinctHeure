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
            ArrayList listeCodeNece = new ArrayList();      //type de vehicule necessaire (un seul par type)
            ArrayList listeNbrNece = new ArrayList();       //nombre de vehicule necessaire de chaque type
            int verifValide = 0;            //vérifie que la liste finale contient tous les numéros des engins

            dgvEng.Columns.Clear();

            dgvEng.Columns.Add("Engin", "Engin");
            dgvEng.Columns.Add("Nombre", "Nombre");

            int idSin = cboNatSin.SelectedIndex + 1;        //id du sinistre
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Necessiter"].Rows)
            {
                if (Convert.ToInt32(dr["idNatureSinistre"]) == idSin)
                {
                    listeCodeNece.Add(dr["codeTypeEngin"]);
                    listeNbrNece.Add(dr["nombre"]);
                    verifValide += Convert.ToInt32(dr["nombre"]);
                }
            }

            ArrayList listeCodeVehi = new ArrayList();    //contient tous les véhicules nécésaires, dans tout leurs exemplaires disponibles
            ArrayList listeNumeroVehi = new ArrayList();         //contient les numéros de tous les véhicules de listeCodeVehi

            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Engin"].Rows)
            {
                if (Convert.ToInt32(dr["idCaserne"]) == cboCasMob.SelectedIndex + 1)      //si la caserne de l'engin est celle demandée
                {
                    foreach(string Eng in listeCodeNece)     //pour chaque engin nécéssaire
                    {
                        if (Eng == dr["codeTypeEngin"].ToString())      //si le code engin est le meme que celui nécéssaire
                        {
                            if ((Convert.ToInt32(dr["enMission"]) == 0) && (Convert.ToInt32(dr["enPanne"]) == 0))       //si l'engin est disponible
                            {
                                listeNumeroVehi.Add(dr["numero"]);
                                listeCodeVehi.Add(Eng);
                            }
                        }
                    }
                }
            }

            int indexAjoutNumero;           //index de la valeur de listeNumeroVehi à ajouter dans listeNumVehiFinale
            int verifNbrVehi;               //assure qu'il n'y a pas plus d'engin du meme type que nécéssaire
            int indexNbrVehi = 0;           //assure qu'il n'y a pas plus d'engin du meme type que nécéssaire en vérifiant dans listeNrbVehi
            ArrayList listeNumVehiFinale = new ArrayList();         //arraylist finale contenant uniquement les numéros des engins qui sont utilisés pour la mission

            foreach (string eeng in listeCodeNece)
            {
                indexAjoutNumero = 0;
                verifNbrVehi = 0;
                foreach (string eng in listeCodeVehi)
                {
                    if ((eeng == eng) && (verifNbrVehi < Convert.ToInt32(listeNbrNece[indexNbrVehi])))
                    {
                        listeNumVehiFinale.Add(listeNumeroVehi[indexAjoutNumero]);
                        verifNbrVehi++;
                    }
                    indexAjoutNumero++;
                }
                indexNbrVehi++;
            }

            bool validate = true;
            if (listeNumVehiFinale.Count != verifValide)        //si il n'y a pas le meme nombre, alors certains vehicules ne sont pas disponibles en assez grand nombre
            {
                validate = false;
            }

            ArrayList listeCodeVehiPrPomp = new ArrayList();

            // sert à vérifier que tous les engins sont disponibles en nombre suffisant
            if (!validate)           // si l'un des engins n'est pas disponible
            {
                MessageBox.Show("certains Engins ne sont pas disponibles, choisissez une autre caserne.");
            }
            else
            {
                int indexNumVehi = 0;       //index du numéro de l'engin à ajouter
                int indexNbrVehic = 0;      //index du nombre d'engin du meme type (vehi n'en contient qu'un, il faut donc une boucle)
                foreach (string vehi in listeCodeNece)
                {
                    if (Convert.ToInt32(listeNbrNece[indexNbrVehic]) > 1)
                    {
                        dgvEng.Rows.Add(vehi, listeNumVehiFinale[indexNumVehi]);      //ajout de l'engin dans le dgv
                        indexNumVehi++;
                        listeCodeVehiPrPomp.Add(vehi.ToString());
                    }
                    dgvEng.Rows.Add(vehi, listeNumVehiFinale[indexNumVehi]);      //ajout de l'engin dans le dgv
                    indexNumVehi++;
                    indexNbrVehic++;
                    listeCodeVehiPrPomp.Add(vehi.ToString());
                }
            }



            dgvPomp.Columns.Clear();

            dgvPomp.Columns.Add("matricule", "matricule");
            dgvPomp.Columns.Add("nom", "nom");
            dgvPomp.Columns.Add("prenom", "prenom");
            dgvPomp.Columns.Add("habilitation", "habilitation");




            ArrayList listeIdHab = new ArrayList();
            ArrayList listeHabNbr = new ArrayList();

            foreach (string vehi in listeCodeVehiPrPomp)
            {
                //tt sur les pompiers   (matricule nom prenom habilitation)
                //embarquer : codeTypeEngin -> idHabilitation et nombre     (pour avoir le bon nombre de pompiers de la bonne habilitation)
                //prendre dse matricules

                //MessageBox.Show("j'affiche");

                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Embarquer"].Rows)
                {
                    if (dr["codeTypeEngin"].ToString() == vehi)
                    {
                        //MessageBox.Show("j'afficheeeee");
                        listeIdHab.Add(dr["idHabilitation"].ToString());
                        listeHabNbr.Add(dr["nombre"]);

                        //MessageBox.Show( dr["idHabilitation"].ToString() + dr["nombre"].ToString());
                    }
                }
            }

            //int i = 0;
            //int z = 0;
            ArrayList listePomp = new ArrayList();
            ArrayList unPomp = new ArrayList();


            int j = 0;
            bool te = false;
            bool tee = false;

            foreach (string idHab in listeIdHab)
            {
                for (int i = 0; i < Convert.ToInt32(listeHabNbr[j]); i++)
                {
                    if (!te)
                    {
                        foreach (DataRow dr in MesDatas.DsGlobal.Tables["Passer"].Rows)
                        {
                            if (dr["idHabilitation"].ToString() == idHab)
                            {
                                foreach (DataRow drr in MesDatas.DsGlobal.Tables["pompier"].Rows)
                                {
                                    if ((drr["matricule"].ToString() == dr["matriculePompier"].ToString()) && (Convert.ToInt32(drr["enMission"]) == 0) && (Convert.ToInt32(drr["enConge"]) == 0) && (te == false))
                                    {
                                        foreach (string pomp in listePomp)
                                        {
                                            if (pomp.ToString() == drr["matricule"].ToString())
                                            {
                                                tee = true;
                                            }
                                        }

                                        if (!tee)
                                        {
                                            unPomp.Add(drr["matricule"]);
                                            listePomp.Add(drr["matricule"].ToString());
                                            unPomp.Add(drr["nom"]);
                                            unPomp.Add(drr["prenom"]);
                                            unPomp.Add(idHab);
                                            //MessageBox.Show("j'ajoute");
                                            dgvPomp.Rows.Add(unPomp[0], unPomp[1], unPomp[2], unPomp[3]);
                                            unPomp.Clear();
                                            te = true;
                                        }
                                        tee = false;
                                    }
                                }
                            }
                        }
                    }
                    te = false;
                }
                j++;
            }


            //maintenant il faut afficher joliement :)
            //arraylist d'arraylist ?

        }
    }
}
