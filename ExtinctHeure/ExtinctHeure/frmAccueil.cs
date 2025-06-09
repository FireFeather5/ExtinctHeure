using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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




            int taille = this.Width;
            int tailBout = (taille / 5) - 2;
            int gauc = 0;

            System.Windows.Forms.Button but = new System.Windows.Forms.Button();
            but.Text = "Tableau de Bord";
            but.Top = 0;
            but.Left = gauc;
            but.Width = tailBout;
            but.Height = 85;
            gauc += tailBout - 1;

            this.Controls.Add(but);


            but = new System.Windows.Forms.Button();
            but.Text = "Ajout de Mission";
            but.Top = 0;
            but.Left = gauc;
            but.Width = tailBout;
            but.Height = 85;
            gauc += tailBout - 1;

            this.Controls.Add(but);


            but = new System.Windows.Forms.Button();
            but.Text = "Visualisation des Engins";
            but.Top = 0;
            but.Left = gauc;
            but.Width = tailBout;
            but.Height = 85;
            gauc += tailBout - 1;

            this.Controls.Add(but);


            but = new System.Windows.Forms.Button();
            but.Text = "Gestion du Personnel";
            but.Top = 0;
            but.Left = gauc;
            but.Width = tailBout;
            but.Height = 85;
            gauc += tailBout - 1;

            this.Controls.Add(but);


            but = new System.Windows.Forms.Button();
            but.Text = "Statistiques";
            but.Top = 0;
            but.Left = gauc;
            but.Width = tailBout;
            but.Height = 85;
            gauc += tailBout - 1;

            this.Controls.Add(but);



        }

        private void txtRue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((char.IsLetter(e.KeyChar)) || (char.IsNumber(e.KeyChar)))
            {
                e.Handled = false;
            }
            if ((e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
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
            if (txtCP.Text.Length < 5)
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
            if ((e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
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

            bool pbTxt = false;

            if (txtMotif.Text == "")
            {
                epTxt.SetError(txtMotif, "Le motif est vide");
                pbTxt = true;
            }
            else
            {
                epTxt.SetError(txtMotif, "");
            }
            if (txtVille.Text == "")
            {
                epTxt.SetError(txtVille, "La ville n'est pas renseignée");
                pbTxt = true;
            }
            else
            {
                epTxt.SetError(txtVille, "");
            }

            if (cboCasMob.SelectedIndex == -1)
            {
                epTxt.SetError(cboCasMob, "Il faut sélectionner une caserne");
                pbTxt = true;
            }
            else
            {
                epTxt.SetError(cboCasMob, "");
            }
            if (cboNatSin.SelectedIndex == -1)
            {
                epTxt.SetError(cboNatSin, "Il faut sélectionner un sinistre");
                pbTxt = true;
            }
            else
            {
                epTxt.SetError(cboNatSin, "");
            }




            if (!pbTxt)
            {
                btnAnn.Visible = false;
                btnAnn.Enabled = false;

                btnConstEqu.Visible = false;
                btnConstEqu.Enabled = false;

                grbEP.Controls.Clear();



                ArrayList listeCodeNece = new ArrayList();      //type de vehicule necessaire (un seul par type)
                ArrayList listeNbrNece = new ArrayList();       //nombre de vehicule necessaire de chaque type
                int verifValide = 0;            //vérifie que la liste finale contient tous les numéros des engins



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
                        foreach (string Eng in listeCodeNece)     //pour chaque engin nécéssaire
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

                    btnAnn.Visible = true;
                    btnAnn.Enabled = true;

                    btnConstEqu.Visible = true;
                    btnConstEqu.Enabled = true;
                }
                else
                {
                    int indexNumVehi = 0;       //index du numéro de l'engin à ajouter
                    int indexNbrVehic = 0;      //index du nombre d'engin du meme type (vehi n'en contient qu'un, il faut donc une boucle)
                    foreach (string vehi in listeCodeNece)
                    {
                        if (Convert.ToInt32(listeNbrNece[indexNbrVehic]) > 1)
                        {
                            indexNumVehi++;
                            listeCodeVehiPrPomp.Add(vehi.ToString());

                        }
                        indexNumVehi++;
                        indexNbrVehic++;
                        listeCodeVehiPrPomp.Add(vehi.ToString());
                    }



                    ArrayList listeIdHab = new ArrayList();         //contient la liste des habilitations
                    ArrayList listeHabNbr = new ArrayList();        //contient le nombre de pompier qu'il faut pour chaque habilitation


                    ArrayList listeTotaleVehi = new ArrayList();        //contient tous les véhicules dans tous leurs exemplaires pour chaque habilitation (utile pour l'affichage)
                    ArrayList listeTotaleNumVehi = new ArrayList();      //contient les numéros de tous les véhicules pour chaque habilitation

                    int indexNumVeh = 0;

                    foreach (string vehi in listeCodeVehiPrPomp)
                    {

                        foreach (DataRow dr in MesDatas.DsGlobal.Tables["Embarquer"].Rows)
                        {
                            if (dr["codeTypeEngin"].ToString() == vehi)
                            {
                                listeIdHab.Add(dr["idHabilitation"].ToString());
                                listeHabNbr.Add(dr["nombre"]);
                                listeTotaleVehi.Add(vehi);

                                listeTotaleNumVehi.Add(listeNumVehiFinale[indexNumVeh]);

                            }
                        }
                        indexNumVeh++;
                    }

                    int n = 0;
                    foreach (DataRow dar in MesDatas.DsGlobal.Tables["Mission"].Rows)
                    {
                        if (n < Convert.ToInt32(dar["id"]))
                        {
                            n = Convert.ToInt32(dar["id"]);
                        }
                    }
                    n++;


                    ArrayList listePomp = new ArrayList();      //contient les pompiers déjà présents dans la mission

                    int haut = 30;
                    int gauche = 100;
                    int l = 0;
                    int j = 0;
                    bool te = false;
                    bool tee = false;

                    foreach (string idHab in listeIdHab)        //pour chaque habilitation (de chaque vehicule)
                    {
                        for (int i = 0; i < Convert.ToInt32(listeHabNbr[j]); i++)       //pour le nombre de fois qu'il faut l'habilitation
                        {
                            if (!te)        //si un pompier n'a pas encore été trouvé
                            {
                                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Passer"].Rows)     //pour chaque rangé de Passer
                                {
                                    if (dr["idHabilitation"].ToString() == idHab)       //si l'habilitation passée par le pompier est celle recherchée
                                    {
                                        //SI la caserne est la bonne (Affectation)
                                        foreach (DataRow drCas in MesDatas.DsGlobal.Tables["Affectation"].Rows)
                                        {
                                            if (Convert.ToInt32(drCas["idCaserne"]) == cboCasMob.SelectedIndex + 1)      //si la caserne de l'engin est celle demandée
                                            {
                                                foreach (DataRow drr in MesDatas.DsGlobal.Tables["pompier"].Rows)       //pour chaque pompier
                                                {
                                                    if (drCas["matriculePompier"].ToString() == drr["matricule"].ToString())
                                                    {
                                                        if ((drr["matricule"].ToString() == dr["matriculePompier"].ToString()) && (Convert.ToInt32(drr["enMission"]) == 0) && (Convert.ToInt32(drr["enConge"]) == 0) && (te == false))
                                                        //si le pompier est celui recherché qu'il n'est ni en mission ni en congé et que le pompier n'a pas été trouvé
                                                        {
                                                            foreach (string pomp in listePomp)      //pour chaque pompier déjà sélectionné
                                                            {
                                                                if (pomp.ToString() == drr["matricule"].ToString())     //si le pompier sélectionné pour l'habilitation est déjà sélectionné pour une autre
                                                                {
                                                                    tee = true;         //on ne le sélectionne pas à nouveau
                                                                }
                                                            }

                                                            if (!tee)       //si il n'est pas encore dans la liste
                                                            {
                                                                listePomp.Add(drr["matricule"].ToString());       //On l'ajoute

                                                                string Eng = listeTotaleVehi[j].ToString() + listeTotaleNumVehi[j].ToString();
                                                                string Pom = drr["matricule"] + "   " + drr["nom"] + "   " + drr["prenom"] + "   " + idHab;

                                                                UCPompierMission.UserControl1 lbl = new UCPompierMission.UserControl1(Eng, Pom);
                                                                lbl.Top = haut;
                                                                lbl.Left = gauche;
                                                                lbl.Width = 400;
                                                                haut += 30;
                                                                l++;


                                                                if (l % 8 == 0)
                                                                {
                                                                    haut = 30;
                                                                    gauche = gauche + 500;
                                                                }

                                                                grbEP.Controls.Add(lbl);

                                                                te = true;

                                                                foreach (DataRow drrr in MesDatas.DsGlobal.Tables["Pompier"].Rows)       //pour chaque pompier
                                                                {
                                                                    if (drrr["matricule"].ToString() == dr["matriculePompier"].ToString())
                                                                    {
                                                                        drrr.BeginEdit();
                                                                        drrr["enMission"] = 1;
                                                                        drrr.EndEdit();
                                                                    }
                                                                }



                                                                MesDatas.DsGlobal.Tables["Mobiliser"].Rows.Add(drr["matricule"], n, idHab);


                                                            }
                                                            tee = false;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            te = false;
                        }
                        j++;
                    }


                    int u = 0;
                    foreach (String codeVeh in listeTotaleVehi)
                    {
                        foreach (DataRow dr in MesDatas.DsGlobal.Tables["Engin"].Rows)
                        {
                            if (dr["idCaserne"].ToString() == (cboCasMob.SelectedItem).ToString())
                            {
                                if (dr["codeTypeEngin"].ToString() == codeVeh)
                                {
                                    if (dr["numero"].ToString() == listeTotaleNumVehi[u].ToString())
                                    {
                                        dr.BeginEdit();
                                        dr["enMission"] = 1;
                                        dr.EndEdit();

                                    }
                                }
                            }
                        }
                        u++;
                    }

                    int numVehi = 0;
                    foreach (String codeVehi in listeTotaleVehi)
                    {
                        MesDatas.DsGlobal.Tables["PartirAvec"].Rows.Add((cboCasMob.SelectedIndex + 1), codeVehi, listeTotaleNumVehi[numVehi], n, null);
                        numVehi++;
                    }


                    if (listePomp.Count > 0)
                    {
                        MesDatas.DsGlobal.Tables["Mission"].Rows.Add(n, DateTime.Now, null, txtMotif.Text, txtRue.Text, txtCP.Text, txtVille.Text, 0, null, (cboNatSin.SelectedIndex + 1), (cboCasMob.SelectedIndex + 1));

                        MessageBox.Show("La mission à bien été ajoutée.");


                        txtMotif.Text = "";
                        txtRue.Text = "";
                        txtCP.Text = "";
                        txtVille.Text = "";
                        cboCasMob.SelectedIndex = -1;
                        cboNatSin.SelectedIndex = -1;

                    }
                    else
                    {
                        MessageBox.Show("Il n'y a plus de pompiers disponibles pour la mission dans cette caserne.");
                    }

                    btnAnn.Visible = true;
                    btnAnn.Enabled = true;

                    btnConstEqu.Visible = true;
                    btnConstEqu.Enabled = true;
                }
            }
        }

        private void btnAnn_Click(object sender, EventArgs e)
        {
            txtMotif.Text = "";
            txtRue.Text = "";
            txtCP.Text = "";
            txtVille.Text = "";
            cboCasMob.SelectedIndex = -1;
            cboNatSin.SelectedIndex = -1;
        }
    }
}
