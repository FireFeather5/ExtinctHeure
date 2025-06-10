using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Pinpon;
using ExtinctHeureUC;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExtinctHeure
{
    public partial class frmAccueil : Form
    {

        System.Windows.Forms.Button btnTabBord;

        System.Windows.Forms.Button btnAjouMis;

        System.Windows.Forms.Button btnVisEngin;

        System.Windows.Forms.Button btnGestPers;

        System.Windows.Forms.Button btnStats;


        private List<string> _strBuffer = new List<string>(20);
        private int[] _intBuffer = new int[10];
        private bool _isAlreadyConnected = false;

        private int _matricule = 0;
        private Button _btnChangeGrade;
        private Button _btnAnnulerGrade;
        private Button _btnConfirmGrade;

        // VOLET 1
        DataSet monDS = MesDatas.DsGlobal;
        bool loaded = false;
        iTextSharp.text.Font h1 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
        iTextSharp.text.Font h2 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
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

        // VOLET 3

        BindingSource bsEngin = new BindingSource();

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

            btnTabBord = new System.Windows.Forms.Button();
            btnTabBord.Text = "Tableau de Bord";
            btnTabBord.Top = 0;
            btnTabBord.Left = gauc;
            btnTabBord.Width = tailBout;
            btnTabBord.Height = 85;
            gauc += tailBout - 1;

            btnTabBord.Click += new System.EventHandler(this.btnTabBord_Click);
            this.Controls.Add(btnTabBord);



            btnAjouMis = new System.Windows.Forms.Button();
            btnAjouMis.Text = "Ajout de Mission";
            btnAjouMis.Top = 0;
            btnAjouMis.Left = gauc;
            btnAjouMis.Width = tailBout;
            btnAjouMis.Height = 85;
            gauc += tailBout - 1;

            btnAjouMis.Click += new System.EventHandler(this.btnAjouMis_Click);
            this.Controls.Add(btnAjouMis);



            btnVisEngin = new System.Windows.Forms.Button();
            btnVisEngin.Text = "Visualisation des Engins";
            btnVisEngin.Top = 0;
            btnVisEngin.Left = gauc;
            btnVisEngin.Width = tailBout;
            btnVisEngin.Height = 85;
            gauc += tailBout - 1;

            btnVisEngin.Click += new System.EventHandler(this.btnVisEngin_Click);
            this.Controls.Add(btnVisEngin);



            btnGestPers = new System.Windows.Forms.Button();
            btnGestPers.Text = "Gestion du Personnel";
            btnGestPers.Top = 0;
            btnGestPers.Left = gauc;
            btnGestPers.Width = tailBout;
            btnGestPers.Height = 85;
            gauc += tailBout - 1;

            btnGestPers.Click += new System.EventHandler(this.btnGestPers_Click);
            this.Controls.Add(btnGestPers);



            btnStats = new System.Windows.Forms.Button();
            btnStats.Text = "Statistiques";
            btnStats.Top = 0;
            btnStats.Left = gauc;
            btnStats.Width = tailBout;
            btnStats.Height = 85;
            gauc += tailBout - 1;

            btnStats.Click += new System.EventHandler(this.btnStats_Click);
            this.Controls.Add(btnStats);
        }

        private void btnTabBord_Click(object sender, EventArgs e)
        {
            btnTabBord.Enabled = false;
            btnTabBord.BackColor = System.Drawing.Color.Gray;

            btnAjouMis.Enabled = true;
            btnAjouMis.BackColor = System.Drawing.Color.White;
            btnVisEngin.Enabled = true;
            btnVisEngin.BackColor = System.Drawing.Color.White;
            btnGestPers.Enabled = true;
            btnGestPers.BackColor = System.Drawing.Color.White;
            btnStats.Enabled = true;
            btnStats.BackColor = System.Drawing.Color.White;

            this.Text = "Tableau de bord";

            grpMissions.Visible = true;
            grpMissions.Size = new Size(1205, 755);
            pnlMissions.Size = new Size(1199, 673);
            grpMissions.Location = new Point(12, 100);
            grbVolet2.Visible = false;
            grpEngins.Visible = false;
            pnlGestion.Visible = false;
            grpStat.Visible = false;
        }

        private void btnAjouMis_Click(object sender, EventArgs e)
        {
            btnAjouMis.Enabled = false;
            btnAjouMis.BackColor = System.Drawing.Color.Gray;

            btnTabBord.Enabled = true;
            btnTabBord.BackColor = System.Drawing.Color.White;
            btnVisEngin.Enabled = true;
            btnVisEngin.BackColor = System.Drawing.Color.White;
            btnGestPers.Enabled = true;
            btnGestPers.BackColor = System.Drawing.Color.White;
            btnStats.Enabled = true;
            btnStats.BackColor = System.Drawing.Color.White;

            this.Text = "Ajout de Mission";

            grpMissions.Visible = false;

            grbVolet2.Visible = true;
            grbVolet2.Size = new Size(1205, 755);
            grbVolet2.Location = new Point(12, 100);

            grpEngins.Visible = false;
            pnlGestion.Visible = false;
            grpStat.Visible = false;
        }

        private void btnVisEngin_Click(object sender, EventArgs e)
        {
            btnVisEngin.Enabled = false;
            btnVisEngin.BackColor = System.Drawing.Color.Gray;

            btnTabBord.Enabled = true;
            btnTabBord.BackColor = System.Drawing.Color.White;
            btnAjouMis.Enabled = true;
            btnAjouMis.BackColor = System.Drawing.Color.White;
            btnGestPers.Enabled = true;
            btnGestPers.BackColor = System.Drawing.Color.White;
            btnStats.Enabled = true;
            btnStats.BackColor = System.Drawing.Color.White;

            this.Text = "Visualisation des engins";

            grpMissions.Visible = false;
            grbVolet2.Visible = false;

            grpEngins.Visible = true;
            grpEngins.Size = new Size(1205, 755);
            grpEngins.Location = new Point(12, 100);

            pnlGestion.Visible = false;
            grpStat.Visible = false;
        }

        private void btnGestPers_Click(object sender, EventArgs e)
        {
            btnGestPers.Enabled = false;
            btnGestPers.BackColor = System.Drawing.Color.Gray;

            btnTabBord.Enabled = true;
            btnTabBord.BackColor = System.Drawing.Color.White;
            btnAjouMis.Enabled = true;
            btnAjouMis.BackColor = System.Drawing.Color.White;
            btnVisEngin.Enabled = true;
            btnVisEngin.BackColor = System.Drawing.Color.White;
            btnStats.Enabled = true;
            btnStats.BackColor = System.Drawing.Color.White;

            this.Text = "Gestion du personnel";

            grpMissions.Visible = false;
            grbVolet2.Visible = false;
            grpEngins.Visible = false;

            pnlGestion.Size = new Size(1205, 755);
            pnlGestion.Visible = true;
            chargerCboCasernes(cboCasernes);
            chargerCboPompiersSansCaserne();

            grpStat.Visible = false;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            btnStats.Enabled = false;
            btnStats.BackColor = System.Drawing.Color.Gray;

            btnTabBord.Enabled = true;
            btnTabBord.BackColor = System.Drawing.Color.White;
            btnAjouMis.Enabled = true;
            btnAjouMis.BackColor = System.Drawing.Color.White;
            btnVisEngin.Enabled = true;
            btnVisEngin.BackColor = System.Drawing.Color.White;
            btnGestPers.Enabled = true;
            btnGestPers.BackColor = System.Drawing.Color.White;

            this.Text = "Statistiques";

            grpMissions.Visible = false;
            grbVolet2.Visible = false;
            grpEngins.Visible = false;
            pnlGestion.Visible = false;

            grpStat.Visible = true;
            grpStat.Size = new Size(1205, 755);
            grpStat.Location = new Point(12, 100);
        }

        private void cboCasernes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearAll();
            cboPompiers.Text = String.Empty;
            cboPompiersSansCaserne.Text = String.Empty;

            if (cboCasernes.SelectedIndex != -1)
            {
                lblPompier.Visible = true;
                cboPompiers.Visible = true;
                _intBuffer[6] = cboCasernes.SelectedIndex; // On enregistre la caserne choisi la caserne par défaut
                chargerCboPompiers();
            }
        }

        // Quand on séléctionne un pompier on affiche ses données
        private void cboPompiers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboPompiers.SelectedItem != null)
            {
                grpInfosPerso.Controls.Clear();
                grpInfosPompier.Visible = false;
                cboPompiersSansCaserne.SelectedItem = null;
                ChargerInfosPompiers();
            }
        }
        private void cboPompiersSansCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboPompiersSansCaserne.SelectedItem != null)
            {
                grpInfosPerso.Controls.Clear();
                grpInfosPompier.Visible = false;
                cboPompiers.SelectedItem = null;
                ChargerInfosPompiers();
            }
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


        SQLiteConnection cx = Connexion.Connec; // On s'assure d'avoir la connexion à la base de données

        // Fonction utilisés pour le volet 4
        private void chargerCboCasernes(ComboBox cbo)
        {
            cx = Connexion.Connec; // On s'assure d'avoir la connexion à la base de données
            string req = "SELECT nom, id AS idCaserne FROM Caserne";

            SQLiteDataAdapter daCaserne = new SQLiteDataAdapter(req, cx);
            DataTable dtCasernes = new DataTable();

            daCaserne.Fill(dtCasernes);
            cbo.ValueMember = "idCaserne"; // Valeur de la combobox est l'id de la caserne
            cbo.DisplayMember = "nom"; // Affichage du nom de la caserne dans la combobox
            cbo.DataSource = dtCasernes;
            cbo.SelectedIndex = -1; // On ne sélectionne rien par défaut
            Connexion.FermerConnexion();
        }

        private void chargerCboPompiers()
        {
            cx = Connexion.Connec; // On s'assure d'avoir la connexion à la base de données
            // On récupère uniquement les pompiers présent dans la caserne choisie
            string req = "SELECT p.nom || ' ' || p.prenom AS NomComplet, p.matricule FROM Pompier p " +
                         "JOIN Affectation a ON p.matricule = a.matriculePompier " +
                         $"JOIN Caserne c ON a.idCaserne = c.id WHERE lower(c.nom) = '{cboCasernes.Text.ToLower()}' " +
                         "AND a.dateFin IS NULL Order by p.nom";

            SQLiteDataAdapter daPompier = new SQLiteDataAdapter(req, cx);

            DataTable dtPompiers = new DataTable();

            daPompier.Fill(dtPompiers);

            cboPompiers.ValueMember = "matricule"; // Valeur de la combobox est le matricule du pompier
            cboPompiers.DisplayMember = "nomComplet"; // Affichage du nom et prénom dans la combobox
            cboPompiers.DataSource = dtPompiers;
            cboPompiers.SelectedItem = null; // On ne sélectionne rien par défaut
            Connexion.FermerConnexion();
        }

        private void chargerCboPompiersSansCaserne()
        {
            cx = Connexion.Connec; // On s'assure d'avoir la connexion à la base de données
            // On récupère uniquement les pompiers présent dans la caserne choisie
            string req = "SELECT p.nom || ' ' || p.prenom AS NomComplet, p.matricule FROM Pompier p " +
                         "JOIN Affectation a ON p.matricule = a.matriculePompier " +
                         "WHERE p.matricule NOT IN (SELECT a.matriculePompier FROM Affectation a WHERE a.dateFin IS NULL)";

            SQLiteDataAdapter daPompier = new SQLiteDataAdapter(req, cx);

            DataTable dtPompiers = new DataTable();

            daPompier.Fill(dtPompiers);

            cboPompiersSansCaserne.ValueMember = "matricule"; // Valeur de la combobox est le matricule du pompier
            cboPompiersSansCaserne.DisplayMember = "nomComplet"; // Affichage du nom et prénom dans la combobox
            cboPompiersSansCaserne.DataSource = dtPompiers;
            cboPompiersSansCaserne.SelectedItem = null; // On ne sélectionne rien par défaut
            Connexion.FermerConnexion();
        }

        private void ChargerInfosPompiers()
        {
            cx = Connexion.Connec; // On s'assure d'avoir la connexion à la base de données

            grpInfosPompier.Visible = false;
            clearAll();
            grpInfosPompier.Visible = true;

            if (cboPompiers.SelectedIndex != -1)
            {
                _matricule = Convert.ToInt32(cboPompiers.SelectedValue);
                _intBuffer[5] = _matricule;
            }
            else
            {
                _matricule = Convert.ToInt32(cboPompiersSansCaserne.SelectedValue);
                _intBuffer[5] = _matricule;
            }

            // Ci-dessous tous les composants dont on a besoin pour afficher les infos du pompier
            GroupBox grpCarriere = new GroupBox
            {
                Text = "Carrière",
                Size = new Size(720, 125),
                Location = new Point(10, 230),
                Visible = true,
                ForeColor = Color.White
            };
            grpInfosPerso.Controls.Add(grpCarriere);

            // On affiche le grade du pompier
            PictureBox grade = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Top = 100,
                Left = 550,
                Size = new Size(100, 100)
            };
            grpInfosPerso.Controls.Add(grade);

            // Affichage du texte du grade
            Label lblGrade = new Label
            {
                Font = new System.Drawing.Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel),
                TextAlign = ContentAlignment.MiddleCenter,
                Top = 50,
                Left = 520,
                Width = 160,
                Height = 40
            };
            grpInfosPerso.Controls.Add(lblGrade);

            // Création de la TextBox pour le code du grade
            TextBox txtCode = new TextBox
            {
                Top = 23,
                Left = 115,
                Size = new Size(75, 30),
                Enabled = false
            };
            grpCarriere.Controls.Add(txtCode);

            // On affiche directement le nom du grade à côté du grade
            ComboBox cboGrades = new ComboBox
            {
                Top = 23,
                Left = 200,
                Size = new Size(200, 20),
                Enabled = false,
            };
            grpCarriere.Controls.Add(cboGrades);

            // Bouton Modifier
            _btnChangeGrade = new Button
            {
                Text = "Modifier",
                Font = new System.Drawing.Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
                ForeColor = Color.DarkRed,
                Size = new Size(100, 27),
                Location = new Point(550, 23),
                Cursor = Cursors.Hand,
                Visible = false,
            };
            grpCarriere.Controls.Add(_btnChangeGrade);

            // Bouton Annuler
            _btnAnnulerGrade = new Button
            {
                Text = "Annuler",
                Font = new System.Drawing.Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
                Size = new Size(100, 27),
                Location = new Point(550, 58),
                Visible = false,
                Cursor = Cursors.Hand
            };
            grpCarriere.Controls.Add(_btnAnnulerGrade);

            // Bouton Confirmer
            _btnConfirmGrade = new Button
            {
                Text = "Confirmer",
                Font = new System.Drawing.Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
                ForeColor = Color.DarkGreen,
                Size = new Size(100, 27),
                Location = new Point(550, 88),
                Visible = false,
                Cursor = Cursors.Hand
            };
            grpCarriere.Controls.Add(_btnConfirmGrade);

            // Événements
            cboGrades.SelectedValueChanged += cboGrades_SelectedValueChanged;
            _btnChangeGrade.Click += BtnChange_Click;
            _btnConfirmGrade.Click += BtnConfirm_Click;
            _btnAnnulerGrade.Click += BtnAnnulerGrade_Click;

            // Requête pour remplir les infos persos
            string req = $@"SELECT p.matricule, p.nom, p.prenom, p.sexe, p.dateNaissance, p.type, p.dateEmbauche, p.codeGrade, g.libelle, p.enConge
                            FROM Pompier p JOIN Grade g ON p.codeGrade = g.code WHERE matricule = {_matricule}";
            SQLiteCommand cmd = new SQLiteCommand(req, cx);
            SQLiteDataReader pompierReader = cmd.ExecuteReader();

            string[] labelsPerso = {"Matricule", "Nom", "Prénom", "Sexe", "Date de Naissance",
                                    "Type", "Date d'embauche", "Code grade", "Libelle", "En conge"};

            while (pompierReader.Read())
            {
                for (int i = 0; i < labelsPerso.Length; i++)
                {
                    Label lbl = new Label();
                    string valeur = "";

                    if (pompierReader.GetFieldType(i).ToString() == "System.Int64")
                    {
                        if (pompierReader.GetInt32(i) == 0)
                            ckbConge.Checked = false;
                        else if (pompierReader.GetInt32(i) == 1)
                            ckbConge.Checked = true;
                        else
                            valeur = pompierReader.GetInt32(i).ToString();
                    }
                    else
                    {
                        if (pompierReader.GetString(i) == "m")
                        {
                            valeur = "Homme ♂";
                        }
                        else if (pompierReader.GetString(i) == "f")
                        {
                            valeur = "Femme ♀";
                        }
                        else if (pompierReader.GetString(i) == "v")
                        {
                            valeur = "Volontaire";
                        }
                        else if (pompierReader.GetString(i) == "p")
                        {
                            valeur = "Professionnel";
                        }
                        else
                        {
                            valeur = pompierReader.GetString(i);
                        }
                    }

                    if (labelsPerso[i] == "Matricule")
                    {
                        lbl.Text = $"{labelsPerso[i]} : {valeur}";
                        lbl.Font = new System.Drawing.Font("Arial", 26, FontStyle.Bold, GraphicsUnit.Pixel);
                        lbl.Height = 40;
                        lbl.Top = 25;
                        lbl.Left = 250;
                        lbl.Width = lbl.Text.Length * 15;
                        grpInfosPerso.Controls.Add(lbl);
                    }
                    else if (labelsPerso[i] == "Code grade")
                    {
                        grade.ImageLocation = $@"..\..\..\..\Ressources\ImagesGrades\{valeur}.png";
                        grade.Load();
                        grpInfosPerso.Controls.Add(grade);
                    }
                    else if (labelsPerso[i] == "Libelle")
                    {
                        lblGrade.Text = $"Grade : \n{valeur}";
                        grpInfosPerso.Controls.Add(lblGrade);
                    }
                    else
                    {
                        lbl.Text = $"{labelsPerso[i]} : {valeur}";
                        lbl.Top = i * 33;
                        lbl.Left = 10;
                        lbl.Width = lbl.Text.Length * 12;
                        lbl.Height = 20;
                        grpInfosPerso.Controls.Add(lbl);
                    }
                }
            }

            // Requête carrière
            req = $@"SELECT p.codeGrade, g.libelle, p.portable, p.bip
                     FROM Pompier p 
                     JOIN Grade g ON p.codeGrade = g.code
                     WHERE matricule = {_matricule}";

            cmd = new SQLiteCommand(req, cx);
            pompierReader = cmd.ExecuteReader();

            string[] labelsCarriere = { "Code grade", "Libelle", "Portable", "Bip" };

            while (pompierReader.Read())
            {
                for (int i = 0; i < labelsCarriere.Length; i++)
                {
                    Label lbl = new Label();
                    string valeur;

                    try
                    {
                        valeur = pompierReader.GetString(i);
                    }
                    catch
                    {
                        valeur = pompierReader.GetInt32(i).ToString();
                    }

                    if (labelsCarriere[i] == "Code grade")
                    {
                        lbl.Text = $"{labelsCarriere[i]} : ";
                        lbl.Top = 25;
                        lbl.Left = 10;
                        lbl.Size = new Size(100, 20);
                        grpCarriere.Controls.Add(lbl);
                        txtCode.Text = valeur;
                        _strBuffer.Add(valeur);
                    }
                    else if (labelsCarriere[i] == "Libelle")
                    {
                        cboGrades.Text = valeur;
                        _strBuffer.Add(valeur);
                    }
                    else
                    {
                        lbl.Text = $"{labelsCarriere[i]} : {valeur}";
                        lbl.Top = i * 30;
                        lbl.Left = 10;
                        lbl.Size = new Size(200, 20);
                        grpCarriere.Controls.Add(lbl);
                    }
                }
            }
            if (cboCasernes.SelectedIndex != -1)
            {
                chargerCboCasernes(cboChoixCaserne);
                cboChoixCaserne.SelectedValue = cboCasernes.SelectedValue; // On sélectionne la caserne ou le pompier est affecté par défaut
            }

            _intBuffer[1] = originalState();

            int compteur = 0;

            string reqHabilitationPasses = $@"SELECT h.libelle
                                              FROM Habilitation h
                                              JOIN Passer pass ON h.id = pass.idHabilitation
                                              JOIN Pompier p ON p.matricule = pass.matriculePompier
                                              WHERE p.matricule = {_matricule}";

            string reqHabilitations = "SELECT libelle FROM Habilitation";

            string reqAncienneCasernes = $@"SELECT c.nom, aff.dateA, COALESCE(aff.dateFin, 'Aucune')
                                            FROM Affectation aff
                                            JOIN Caserne c ON aff.idCaserne = c.id
                                            JOIN Pompier p ON aff.matriculePompier = p.matricule
                                            WHERE p.matricule = {_matricule}";

            string enConge = $"SELECT enConge FROM Pompier WHERE matricule = {_matricule}";

            cx = Connexion.Connec;

            SQLiteCommand cmdHabilitationPasses = new SQLiteCommand(reqHabilitationPasses, cx);
            SQLiteCommand cmdHabilitations = new SQLiteCommand(reqHabilitations, cx);
            SQLiteCommand cmdAncienneCasernes = new SQLiteCommand(reqAncienneCasernes, cx);
            SQLiteCommand cmdEnConge = new SQLiteCommand(enConge, cx);
            SQLiteDataReader readerHabilitationPasses = cmdHabilitationPasses.ExecuteReader();
            SQLiteDataReader readerHabilitations = cmdHabilitations.ExecuteReader();
            SQLiteDataReader readerAncienneCasernes = cmdAncienneCasernes.ExecuteReader();
            SQLiteDataReader readerEnConge = cmdEnConge.ExecuteReader();

            while (readerHabilitationPasses.Read())
            {
                string habilitation = readerHabilitationPasses.GetString(0);
                chklstHabilitations.Items.Add(habilitation);
                chklstHabilitations.SetItemChecked(chklstHabilitations.Items.IndexOf(habilitation), true);
                _strBuffer.Add(habilitation);
                compteur++;
            }

            while (readerHabilitations.Read())
            {
                if (!chklstHabilitations.Items.Contains(readerHabilitations.GetString(0)))
                {
                    string habilitation = readerHabilitations.GetString(0);
                    chklstHabilitations.Items.Add(habilitation);
                }
            }

            while (readerAncienneCasernes.Read())
            {
                string ancienneCasernes = readerAncienneCasernes.GetString(0);
                string dateDebut = readerAncienneCasernes.GetString(1);
                if (readerAncienneCasernes.GetString(2) != "Aucune")
                {
                    string dateFin = readerAncienneCasernes.GetString(2);
                    lstAnciennesCasernes.Items.Add(ancienneCasernes + ", du " + dateDebut.Replace('-', '/') + " au " + dateFin.Replace('-', '/'));
                }
                else if (lstAnciennesCasernes.Items.Count < 1)
                {
                    lstAnciennesCasernes.Items.Add("Aucune ancienne affectation");
                }
            }

            while (readerEnConge.Read())
            {
                if (readerEnConge.GetInt32(0) == 1)
                {
                    ckbConge.Checked = true;
                }
                else
                {
                    ckbConge.Checked = false;
                }
            }

            _intBuffer[0] = compteur;

            // Méthodes internes
            void cboGrades_SelectedValueChanged(object sender, EventArgs e)
            {
                if (!string.IsNullOrEmpty(cboGrades.Text))
                {
                    req = $@"SELECT code FROM Grade WHERE libelle = '{cboGrades.Text}'";
                    cmd = new SQLiteCommand(req, cx);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtCode.Text = reader.GetString(0);
                    }
                }
            }

            void BtnChange_Click(object sender, EventArgs e)
            {
                cx = Connexion.Connec;
                _btnAnnulerGrade.Visible = true;
                _btnConfirmGrade.Visible = true;

                cboGrades.Text = string.Empty;
                cboGrades.Items.Clear();
                cboGrades.Enabled = true;

                req = "SELECT libelle FROM Grade";
                cmd = new SQLiteCommand(req, cx);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nomGrade = reader.GetString(0);
                    cboGrades.Items.Add(nomGrade);
                }
                Connexion.FermerConnexion();
            }

            void BtnAnnulerGrade_Click(object sender, EventArgs e)
            {
                txtCode.Text = _strBuffer[0];
                cboGrades.Text = _strBuffer[1];
                txtCode.Enabled = false;
                cboGrades.Enabled = false;

                _btnAnnulerGrade.Visible = false;
                _btnConfirmGrade.Visible = false;
            }

            void BtnConfirm_Click(object sender, EventArgs e)
            {
                SQLiteTransaction transaction = cx.BeginTransaction();

                req = $@"UPDATE Pompier SET codeGrade = '{txtCode.Text}' WHERE matricule = {_matricule}";
                SQLiteCommand cmdUpdate = new SQLiteCommand(req, cx)
                {
                    Transaction = transaction
                };

                txtCode.Enabled = false;
                cboGrades.Enabled = false;
                _btnAnnulerGrade.Visible = false;
                _btnConfirmGrade.Visible = false;

                grade.ImageLocation = $@"..\..\..\..\Ressources\ImagesGrades\{txtCode.Text}.png";
                grade.Load();
                lblGrade.Text = $"Grade : \n{cboGrades.Text}";

                _strBuffer[0] = txtCode.Text;
                _strBuffer[1] = cboGrades.Text;

                try
                {
                    cmdUpdate.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Changements confirmés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Connexion.FermerConnexion();
        }

        // Boutons pour afficher des informations supplémentaires sur la carrière du pompier
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_isAlreadyConnected)
            {
                frmConnexion connexion = new frmConnexion();
                if (connexion.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Vous êtes bien connecté", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _isAlreadyConnected = true;
                }
                else
                {
                    MessageBox.Show("Accès non autorisé", "Refus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (_isAlreadyConnected)
            {
                chargerCboCasernes(cboChoixCaserne);
                btnLogin.Visible = false;

                _btnChangeGrade.Visible = true;

                cboChoixCaserne.Enabled = true;
                chklstHabilitations.Enabled = true;
                lstAnciennesCasernes.Enabled = true;
                ckbConge.Enabled = true;

                btnConfirmerMaj.Visible = true;
                btnAnnuler.Visible = true;
            }
        }

        List<string> habilitations = new List<string>();
        private void btnConfirmerMaj_Click(object sender, EventArgs e)
        {
            cx = Connexion.Connec; // On s'assure d'avoir la connexion à la base de données

            bool hasBeenModified = false;

            int compteur = _intBuffer[0];

            string req = "";

            int enConge = 0;
            int originalState = _intBuffer[1];
            bool congeBool = originalState == 1;

            bool transactionWorked = false;

            if (ckbConge.Checked != congeBool)
            {
                SQLiteCommand cmdConge = new SQLiteCommand(req, cx);
                SQLiteTransaction transactionConge = cx.BeginTransaction();
                cmdConge.Transaction = transactionConge;

                if (ckbConge.Checked)
                {
                    enConge = 1;
                }
                else
                {
                    enConge = 0;
                }

                req = $"UPDATE Pompier SET enConge = {enConge} WHERE matricule = {_matricule}";
                cmdConge.CommandText = req;

                try
                {
                    cmdConge.ExecuteNonQuery();
                    transactionConge.Commit();
                    hasBeenModified = true;
                }
                catch (Exception ex)
                {
                    transactionConge.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (chklstHabilitations.CheckedItems.Count > compteur)
            {
                SQLiteCommand cmdHabilitations = new SQLiteCommand(req, cx);
                SQLiteTransaction transactionHabilitations = cx.BeginTransaction();
                cmdHabilitations.Transaction = transactionHabilitations;

                for (int i = compteur; i < chklstHabilitations.CheckedItems.Count; i++)
                {
                    habilitations.Add(chklstHabilitations.CheckedItems[i].ToString());
                }

                for (int i = 0; i < chklstHabilitations.CheckedItems.Count - compteur; i++)
                {
                    req = "INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention) " +
                          $"VALUES ((SELECT matricule FROM Pompier WHERE matricule = {_matricule}), " +
                          $"(SELECT id FROM Habilitation WHERE lower(libelle) = \"{habilitations[i].ToLower()}\"), " +
                          $"'{DateTime.Today.ToString("yyyy-MM-dd")}')";

                    cmdHabilitations.CommandText = req;

                    try
                    {
                        cmdHabilitations.ExecuteNonQuery();
                        transactionWorked = true;
                    }
                    catch (SQLiteException ex)
                    {
                        transactionWorked = false;
                        MessageBox.Show("Erreur SQL : " + ex.Message);
                    }
                }
                if (transactionWorked)
                {
                    try
                    {
                        transactionHabilitations.Commit();
                        hasBeenModified = true;
                    }
                    catch (SQLiteException ex)
                    {
                        transactionHabilitations.Rollback();
                        MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            bool hasBeenModifiedCaserne = false;
            if (cboChoixCaserne.Text != cboCasernes.Text && cboChoixCaserne.SelectedIndex != -1)
            {
                SQLiteCommand cmdCaserne = new SQLiteCommand(req, cx);
                SQLiteTransaction transactionCaserne = cx.BeginTransaction();

                req = $@"UPDATE Affectation SET dateFin = '{DateTime.Today.ToString("yyyy-MM-dd")}'
                      WHERE matriculePompier = (SELECT matricule FROM Pompier WHERE matricule = {_matricule});
                      
                      INSERT INTO Affectation (matriculePompier, dateA, idCaserne)
                      VALUES ((SELECT matricule FROM Pompier WHERE matricule = {_matricule}),
                      '{DateTime.Today:yyyy-MM-dd}', (SELECT id FROM Caserne WHERE lower(nom) = '{cboChoixCaserne.Text.ToLower()}'))";

                cmdCaserne.CommandText = req;
                cmdCaserne.Transaction = transactionCaserne;
                try
                {
                    cmdCaserne.ExecuteNonQuery();
                    transactionCaserne.Commit();
                    hasBeenModifiedCaserne = true;
                }
                catch (SQLiteException ex)
                {
                    transactionCaserne.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (hasBeenModified)
            {
                if (hasBeenModifiedCaserne)
                {
                    chargerCboCasernes(cboCasernes);
                    cboCasernes.SelectedIndex = _intBuffer[6]; // On remet la caserne par défaut
                }
                _matricule = _intBuffer[5];
                ChargerInfosPompiers();
                MessageBox.Show("Changements confirmés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Connexion.FermerConnexion(); // On ferme la connexion à la base de données pour éviter les fuites de mémoire
        }

        private void clearAll()
        {
            grpInfosPerso.Controls.Clear();
            grpInfosPompier.Visible = false;

            btnLogin.Visible = true;
            cboChoixCaserne.SelectedIndex = -1;
            chklstHabilitations.Items.Clear();
            lstAnciennesCasernes.Items.Clear();
        }

        // On créer un nouveau formulaire pour l'ajout d'un pompier dans la DB
        private void pcbIconeNouveau_Click(object sender, EventArgs e)
        {
            if (!_isAlreadyConnected)
            {
                frmConnexion connexion = new frmConnexion();
                if (connexion.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Vous êtes bien connecté", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _isAlreadyConnected = true;
                }
                else
                {
                    MessageBox.Show("Accès non autorisé", "Refus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if( _isAlreadyConnected)
            {
                frmAjoutPompier ajouterPimpon = new frmAjoutPompier();
                if (ajouterPimpon.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Changements confirmés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Changements abandonnés", "Abandon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
                
        }

        private int originalState()
        {
            if (ckbConge.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            int originalState = _intBuffer[1];
            bool congeBool = originalState == 1;
            ckbConge.Checked = congeBool;

            int compteur = _intBuffer[0];
            cboChoixCaserne.SelectedIndex = -1;
            if (chklstHabilitations.CheckedItems.Count > compteur)
            {
                for (int i = compteur; i < chklstHabilitations.Items.Count; i++)
                {
                    chklstHabilitations.SetItemChecked(i, false);
                }
            }
        }

        // VOLET 1

        private void load()
        {
            monDS.Clear();
            cx = Connexion.Connec;
            DataTable SchemaTable = cx.GetSchema("Tables");
            foreach (DataRow row in SchemaTable.Rows)
            {
                String requete = "SELECT * FROM " + row["TABLE_NAME"].ToString();
                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(monDS, row["TABLE_NAME"].ToString());
            }
            Connexion.FermerConnexion();

            monDS.Tables["Caserne"].PrimaryKey = new DataColumn[] { monDS.Tables["Caserne"].Columns["id"] };
            monDS.Tables["NatureSinistre"].PrimaryKey = new DataColumn[] { monDS.Tables["NatureSinistre"].Columns["id"] };

            DataRelation relCaserne = new DataRelation("FK_Mission_idCaserne", monDS.Tables["Caserne"].Columns["id"], monDS.Tables["Mission"].Columns["idCaserne"], false);
            DataRelation relNature = new DataRelation("FK_Mission_idNature", monDS.Tables["NatureSinistre"].Columns["id"], monDS.Tables["Mission"].Columns["idNatureSinistre"], false);
            DataRelation relPompier = new DataRelation("FK_Mobiliser_matriculePompier", monDS.Tables["Pompier"].Columns["matricule"], monDS.Tables["Mobiliser"].Columns["matriculePompier"], false);
            DataRelation relHabilitation = new DataRelation("FK_Mobiliser_idHabilitation", monDS.Tables["Habilitation"].Columns["id"], monDS.Tables["Mobiliser"].Columns["idhabilitation"], false);
            DataRelation relGrade = new DataRelation("FK_Pompier_codeGrade", monDS.Tables["Grade"].Columns["code"], monDS.Tables["Pompier"].Columns["codeGrade"], false);
            DataRelation relEngin = new DataRelation("FK_PartirAvec_codeTypeEngin", monDS.Tables["TypeEngin"].Columns["code"], monDS.Tables["PartirAvec"].Columns["codeTypeEngin"], false);

            monDS.Relations.Clear();

            monDS.Relations.Add(relCaserne);
            monDS.Relations.Add(relNature);
            monDS.Relations.Add(relPompier);
            monDS.Relations.Add(relHabilitation);
            monDS.Relations.Add(relGrade);
            monDS.Relations.Add(relEngin);

            loaded = true;
        }

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

                mission.CreerRapportEvent = genererRapport;
                mission.ClotureMissionEvent = cloturerMission;

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
            doc.Add(Chunk.NEWLINE);

            foreach (DataRow row in monDS.Tables["Mobiliser"].Select("idMission = " + mission.idMission))
            {
                doc.Add(new Paragraph(">>>  " + row.GetParentRow("FK_Mobiliser_matriculePompier").GetParentRow("FK_Pompier_codeGrade")["libelle"] + " " + row.GetParentRow("FK_Mobiliser_matriculePompier")["nom"] + " " + row.GetParentRow("FK_Mobiliser_matriculePompier")["prenom"] + " (" + row.GetParentRow("FK_Mobiliser_idHabilitation")["libelle"] + ")"));
            }

            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Engins utilisés : ", h2));
            doc.Add(Chunk.NEWLINE);

            String repa = "";

            foreach (DataRow row in monDS.Tables["partirAvec"].Select("idMission = " + mission.idMission))
            {
                if (row["reparationsEventuelles"] != DBNull.Value && row["reparationsEventuelles"] != "")
                {
                    repa = row["reparationsEventuelles"].ToString();
                }
                else
                {
                    repa = "Pas de reparations prévues";
                }
                doc.Add(new Paragraph(">>>  " + row.GetParentRow("FK_PartirAvec_codeTypeEngin")["nom"] + " " + row["idCaserne"] + "-" + row["codeTypeEngin"] + "-" + row["numeroEngin"] + " (" + repa + ")"));
            }
            doc.Close();
        }

        private void cloturerMission(object sender, EventArgs e)
        {
            Mission mission = (Mission)sender;
            if (mission.estFini)
            {
                MessageBox.Show("La mission est déjà terminée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form rapport = new frmRapport();
                if (rapport.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        cx = Connexion.Connec;
                        mission.rapportMission = ((frmRapport)rapport).rapport;
                        string requete = $"UPDATE Mission SET dateHeureRetour = datetime('now'), terminee = 1, compteRendu = '{mission.rapportMission}' WHERE id = " + mission.idMission.ToString();
                        SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                        cmd.ExecuteNonQuery();

                        requete = $"UPDATE Pompier SET enMission = 0 WHERE matricule in (SELECT matriculePompier FROM Mobiliser WHERE idMission = {mission.idMission})";
                        cmd = new SQLiteCommand(requete, cx);
                        cmd.ExecuteNonQuery();

                        requete = $"UPDATE Engin SET enMission = 0 WHERE (idCaserne, codeTypeEngin, numero) in (SELECT idCaserne, codeTypeEngin, numeroEngin FROM PartirAvec WHERE idMission = {mission.idMission})";
                        cmd = new SQLiteCommand(requete, cx);
                        cmd.ExecuteNonQuery();

                        mission.estFini = true;
                        mission.finMission = DateTime.Now.ToString();


                        loaded = false;
                        MessageBox.Show("La mission a été clôturée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpMissions_VisibleChanged(sender, e);
                        genererRapport(sender, e);
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show($"Erreur lors de la clôture de la mission : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connexion.FermerConnexion();
                    }
                }
                else
                {
                    MessageBox.Show("La mission n'a pas été clôturée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // VOLET 5

        private void grpStat_VisibleChanged(object sender, EventArgs e)
        {
            if (grpStat.Visible)
            {
                cx = Connexion.Connec;
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
                Connexion.FermerConnexion();
            }
        }

        private void cboCaserneStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cx = Connexion.Connec;
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
            cx = Connexion.Connec;
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

        // VOLET 3

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

        private void grpEngins_VisibleChanged(object sender, EventArgs e)
        {
            if (grpEngins.Visible)
            {
                btnFirst.Image = new Bitmap(System.Drawing.Image.FromFile("../../../../Ressources/ImagesNavigation/premier.png"), new Size(80, 80));
                btnPrevious.Image = new Bitmap(System.Drawing.Image.FromFile("../../../../Ressources/ImagesNavigation/precendent.png"), new Size(80, 80));
                btnNext.Image = new Bitmap(System.Drawing.Image.FromFile("../../../../Ressources/ImagesNavigation/suivant.png"), new Size(80, 80));
                btnLast.Image = new Bitmap(System.Drawing.Image.FromFile("../../../../Ressources/ImagesNavigation/dernier.png"), new Size(80, 80));

                loaded = false;
                lblNumeroEngin.Text = "";
                lblReceptionEngin.Text = "";
                monDS.Clear();
                bsEngin = new BindingSource();
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

                monDS.Relations.Clear();
                monDS.Relations.Add("Caserne_Engin", monDS.Tables["Caserne"].Columns["id"], monDS.Tables["Engin"].Columns["idCaserne"]);

                if (!monDS.Tables["Engin"].Columns.Contains("idComplet"))
                {
                    monDS.Tables["Engin"].Columns.Add(new DataColumn("idComplet", typeof(string), "idCaserne + '-' + codeTypeEngin + '-' + numero"));
                }

                if (!monDS.Tables["Engin"].Columns.Contains("image"))
                {
                    monDS.Tables["Engin"].Columns.Add(new DataColumn("image", typeof(string), "'..\\..\\..\\..\\Ressources\\ImagesCamions\\' + codeTypeEngin + '.jpg'"));
                }

                bsEngin.DataSource = bsCaserne;
                bsEngin.DataMember = "Caserne_Engin";

                lblNumeroEngin.DataBindings.Clear();
                lblReceptionEngin.DataBindings.Clear();
                chkMission.DataBindings.Clear();
                chkReparation.DataBindings.Clear();
                pcbEngin.DataBindings.Clear();

                lblNumeroEngin.DataBindings.Add("Text", bsEngin, "idComplet");
                lblReceptionEngin.DataBindings.Add("Text", bsEngin, "dateReception");
                chkMission.DataBindings.Add("Checked", bsEngin, "enMission");
                chkReparation.DataBindings.Add("Checked", bsEngin, "enPanne");
                pcbEngin.DataBindings.Add("ImageLocation", bsEngin, "image");
            }
        }

        private void frmAccueil_Shown(object sender, EventArgs e)
        {
            btnTabBord_Click(btnTabBord, e);
        }
    }
}
