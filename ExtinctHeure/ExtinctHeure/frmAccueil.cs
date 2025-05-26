using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtinctHeure.Properties;
using Pinpon;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ExtinctHeure
{
    public partial class frmAccueil : Form
    {
        private List<string> _strBuffer = new List<string>(20);
        private int[] _intBuffer = new int[10];
        private int matricule = 0;
        private SQLiteConnection cx;
        public frmAccueil()
        {
            InitializeComponent();
            try
            {
                this.cx = Connexion.Connec;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de l'accès à la DB : " + ex.Message);
            }
        }

        // On charge uniquement la combobox des Casernes dans le load
        private void frmAccueil_Load(object sender, EventArgs e)
        {
            ChargercboCasernes();
        }

        // Une fois une caserne choisi on récupère les pompiers associés à cette caserne
        private void cboCasernes_SelectedValueChanged(object sender, EventArgs e)
        {
            clearAll();
            cboPompiers.Text = String.Empty;

            if (cboCasernes.Text != String.Empty)
            {
                ChargercboPompiers();
                lblPompier.Visible = true;
                cboPompiers.Visible = true;
            }
        }

        // Quand on séléctionne un pompier on affiche ses données

        private void cboPompiers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboPompiers.Text != String.Empty)
            {
                ChargerInfosPompiers();
            }
        }

        // Fonctions pour charger les Casernes et les Pompiers dans la combobox
        private void ChargercboCasernes()
        {
            cboCasernes.Items.Clear();
            clearAll();

            string req = "SELECT nom FROM Caserne";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader caserneReader = cmd.ExecuteReader();

            while (caserneReader.Read())
            {
                string nomCaserne = caserneReader.GetString(0);
                this.cboCasernes.Items.Add(nomCaserne);
            }
        }

        private void ChargercboPompiers()
        {
            // On récupère uniquement les pompiers présent dans la caserne choisie
            string req = "SELECT p.nom, p.prenom, p.matricule FROM Pompier p " +
                         "JOIN Affectation a ON p.matricule = a.matriculePompier " +
                         $"JOIN Caserne c ON a.idCaserne = c.id WHERE lower(c.nom) = '{cboCasernes.Text.ToLower()}' " +
                         "AND a.dateFin IS NULL Order by p.nom";

            SQLiteDataAdapter daPompier = new SQLiteDataAdapter(req, this.cx);

            DataTable dtPompiers = new DataTable();

            daPompier.Fill(dtPompiers);

            DataRow row0 = dtPompiers.NewRow();
            dtPompiers.Rows.InsertAt(row0, 0);

            row0.BeginEdit();
            row0["nom"] = "";
            row0["prenom"] = "";
            row0.AcceptChanges();

            dtPompiers.Columns.Add("nomComplet");
            foreach (DataRow row in dtPompiers.Rows)
            {
                row["nomComplet"] = $"{row["nom"]} {row["prenom"]}"; // On ajoute une colonne pour le nom complet
            }
            
            cboPompiers.ValueMember = "matricule"; // Valeur de la combobox est le matricule du pompier
            cboPompiers.DisplayMember = "nomComplet"; // Affichage du nom et prénom dans la combobox
            cboPompiers.DataSource = dtPompiers;
        }

        // On charge les infos des pompiers
        private void ChargerInfosPompiers()
        {
            grpInfosPompier.Visible = false;

            if (cboPompiers.SelectedValue != DBNull.Value)
            {
                clearAll();
                grpInfosPompier.Visible = true;

                matricule = Convert.ToInt32(cboPompiers.SelectedValue);

                // Ci-dessous tous les composants dont on a besoin pour afficher les infos du pompier

                // On affiche le grade du pompier
                PictureBox grade = new PictureBox();
                grade.SizeMode = PictureBoxSizeMode.Zoom;
                grade.Top = 100;
                grade.Left = 550;
                grade.Size = new Size(100, 100);

                // Affichage du texte du grade
                Label lblGrade = new Label();
                lblGrade.Font = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel);
                lblGrade.TextAlign = ContentAlignment.MiddleCenter;
                lblGrade.Top = 50;
                lblGrade.Left = 520;
                lblGrade.Width = 160;
                lblGrade.Height = 40;

                // Ajout de la groupebox pour les infos de la carrière
                GroupBox grpCarriere = new GroupBox();
                grpCarriere.Text = "Carrière";
                grpCarriere.Size = new Size(720, 125);
                grpCarriere.Location = new Point(10, 230);

                grpInfosPerso.Controls.Add(grpCarriere);

                //Creation de la TextBox pour le code du grade
                TextBox txtCode = new TextBox();
                txtCode.Top = 23;
                txtCode.Left = 115;
                txtCode.Size = new Size(75, 30);
                txtCode.Enabled = false;
                grpCarriere.Controls.Add(txtCode);

                // On affiche directement le nom du grade à coté du grade
                ComboBox cboGrades = new ComboBox();
                cboGrades.Top = 23;
                cboGrades.Left = 200;
                cboGrades.Size = new Size(200, 20);
                cboGrades.Enabled = false;

                grpCarriere.Controls.Add(cboGrades);

                // Creation du bouton pour changer des informations
                Button btnChange = new Button();
                btnChange.Text = "Modifier";
                btnChange.Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel);
                btnChange.ForeColor = Color.DarkRed;
                btnChange.Size = new Size(100, 27);
                btnChange.Location = new Point(550, 23);
                btnChange.Cursor = Cursors.Hand;

                grpCarriere.Controls.Add(btnChange);

                // Creation du bouton pour changer des informations
                Button btnAnnuler = new Button();
                btnAnnuler.Text = "Annuler";
                btnAnnuler.Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel);
                btnAnnuler.Size = new Size(100, 27);
                btnAnnuler.Location = new Point(550, 58);
                btnAnnuler.Visible = false;
                btnAnnuler.Cursor = Cursors.Hand;

                grpCarriere.Controls.Add(btnAnnuler);

                // Creation du bouton pour confirmer le changement des informations
                Button btnConfirm = new Button();
                btnConfirm.Text = "Confirmer";
                btnConfirm.Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel);
                btnConfirm.ForeColor = Color.DarkGreen;
                btnConfirm.Size = new Size(100, 27);
                btnConfirm.Location = new Point(550, 88);
                btnConfirm.Visible = false;
                btnConfirm.Cursor = Cursors.Hand;

                grpCarriere.Controls.Add(btnConfirm);

                // Tous les évènements nécessaires
                cboGrades.SelectedValueChanged += cboGrades_SelectedValueChanged;
                btnChange.Click += BtnChange_Click;
                btnConfirm.Click += BtnConfirm_Click;
                btnAnnuler.Click += BtnAnnuler_Click;

                // Requêtes pour remplir les infos persos sans la carrière
                string req =
                    $@"SELECT p.matricule, p.nom, p.prenom, p.sexe, p.dateNaissance, p.type, p.dateEmbauche, p.codeGrade, g.libelle, p.enConge
                            FROM Pompier p JOIN Grade g on p.codeGrade = g.code
                            WHERE matricule = {matricule}";
                SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
                SQLiteDataReader pompierReader = cmd.ExecuteReader();

                // Tableau des nom des colonnes
                string[] labelsPerso =
                {
                    "Matricule", "Nom", "Prénom", "Sexe", "Date de Naissance",
                    "Type", "Date d'embauche", "Code grade", "Libelle", "En conge"
                };

                while (pompierReader.Read())
                {
                    // Pour uniquement les infos persos
                    for (int i = 0; i < labelsPerso.Length; i++)
                    {
                        Label lbl = new Label();

                        string valeur = "";

                        // Pour les colonnes de la DB ayant pour valeur des entiers
                        if (pompierReader.GetFieldType(i).ToString() == "System.Int64")
                        {
                            // On personnalise ici l'affichage des valeurs pour éviter simplement des nombres
                            if (pompierReader.GetInt32(i) == 0)
                            {
                                ckbConge.Checked = false;
                            }
                            else if (pompierReader.GetInt32(i) == 1)
                            {
                                ckbConge.Checked = true;
                            }
                            else
                            {
                                valeur = pompierReader.GetInt32(i).ToString();
                            }
                        }
                        else
                        {
                            // Pareil ici pour ne pas réduire le sexe à une seule lettre
                            if (pompierReader.GetString(i) == "m")
                            {
                                valeur = "Homme";
                            }
                            else if (pompierReader.GetString(i) == "f")
                            {
                                valeur = "Femme";
                            }
                            else
                            {
                                valeur = pompierReader.GetString(i);
                            }
                        }

                        // Si on souhaite personnaliser les affichages des labels il faut les gérer individuellments
                        if (labelsPerso[i] == "Matricule")
                        {
                            // Ce label est isolé, il faut le gérer séparement des autres
                            lbl.Text = $"{labelsPerso[i]} : " + valeur;

                            // On créer une nouvelle font pour mettre le matricule en valeur
                            lbl.Font = new Font("Arial", 26, FontStyle.Bold, GraphicsUnit.Pixel);
                            lbl.Height = 40;
                            lbl.Top = 25;
                            lbl.Left = 250;
                            lbl.Width = lbl.Text.Length * 15;

                            grpInfosPerso.Controls.Add(lbl);
                        }
                        else if (labelsPerso[i] == "Type")
                        {
                            // Ce label également isolé
                            lbl.Text = "Pompier : ";
                            lbl.Top = i * 33;
                            lbl.Left = 10;
                            lbl.Width = lbl.Text.Length * 9;
                            lbl.Height = 20;

                            // On gère le placement des deux RadioButton
                            RadioButton rdbProfessionel = new RadioButton();
                            rdbProfessionel.Top = (i * 33) - 2;
                            rdbProfessionel.Left = 105;
                            rdbProfessionel.Text = "Professionel";
                            rdbProfessionel.Width = rdbProfessionel.Text.Length * 10;

                            RadioButton rdbVolontaire = new RadioButton();
                            rdbVolontaire.Top = (i * 33) - 2;
                            rdbVolontaire.Left = 235;
                            rdbVolontaire.Text = "Volontaire";

                            if (pompierReader.GetString(i) == "p")
                            {
                                rdbProfessionel.Checked = true;
                                rdbVolontaire.Enabled = false;
                            }
                            else
                            {
                                rdbVolontaire.Checked = true;
                                rdbProfessionel.Enabled = false;
                            }

                            grpInfosPerso.Controls.Add(lbl);
                            grpInfosPerso.Controls.Add(rdbProfessionel);
                            grpInfosPerso.Controls.Add(rdbVolontaire);
                        }
                        else if (labelsPerso[i] == "Code grade")
                        {
                            // Affichage de l'image associé au grade
                            grade.ImageLocation = $@"..\..\..\..\Ressources\images\ImagesGrades\{valeur}.png";
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
                            // Sinon on gère le label de la même manière
                            lbl.Text = $"{labelsPerso[i]} : " + valeur;
                            grpInfosPerso.Controls.Add(lbl);
                            lbl.Top = i * 33;
                            lbl.Left = 10;
                            lbl.Width = lbl.Text.Length * 12;
                            lbl.Height = 20;
                        }
                    }
                }

                // Nouvelle requête pour récupérer les infos de la carrière
                req = $@"SELECT p.codeGrade, g.libelle, p.portable, p.bip
                     FROM Pompier p JOIN Grade g on p.codeGrade = g.code
                     WHERE matricule = {matricule}";
                cmd = new SQLiteCommand(req, this.cx);
                pompierReader = cmd.ExecuteReader();

                //Tableau avec le noms des colonnes pour mieux se repérer
                string[] labelsCarriere = { "Code grade", "Libelle", "Portable", "Bip" };

                while (pompierReader.Read())
                {
                    for (int i = 0; i < labelsCarriere.Length; i++)
                    {
                        Label lbl = new Label();

                        // On gère les labels de la même manière que pour les infos persos
                        string valeur = "";

                        try
                        {
                            valeur = pompierReader.GetString(i);
                        }
                        catch (Exception ex)
                        {
                            valeur = pompierReader.GetInt32(i).ToString();
                        }

                        if (labelsCarriere[i] == "Code grade")
                        {
                            // On personnalise l'affichage du code grade
                            lbl.Text = $"{labelsCarriere[i]} : ";
                            grpCarriere.Controls.Add(lbl);

                            lbl.Top = 25;
                            lbl.Left = 10;
                            lbl.Size = new Size(100, 20);

                            // On affiche le code dans une textBox à coté du libellé du grade
                            txtCode.Text = valeur;
                            // On sauvegarde le code dans un tableau pour le réutiliser plus tard
                            _strBuffer.Add(valeur);
                        }
                        else if (labelsCarriere[i] == "Libelle")
                        {
                            cboGrades.Text = valeur;
                            _strBuffer.Add(valeur);
                        }
                        else
                        {
                            lbl.Text = $"{labelsCarriere[i]} : " + valeur;
                            grpCarriere.Controls.Add(lbl);

                            lbl.Top = i * 30;
                            lbl.Left = 10;
                            lbl.Size = new Size(200, 20);
                        }
                    }

                }

                void cboGrades_SelectedValueChanged(object sender, EventArgs e)
                {
                    // On gère le changement de valeur de la combobox
                    if (cboGrades.Text != String.Empty)
                    {
                        req = $@"SELECT code FROM Grade WHERE libelle = '{cboGrades.Text}'";
                        cmd = new SQLiteCommand(req, this.cx);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtCode.Text = reader.GetString(0);
                        }
                    }
                }

                void BtnChange_Click(object sender, EventArgs e)
                {
                    // On affiche les boutons pour confirmer ou annuler les changements
                    btnAnnuler.Visible = true;
                    btnConfirm.Visible = true;

                    cboGrades.Text = String.Empty;
                    cboGrades.Items.Clear();
                    cboGrades.Enabled = true;

                    req = $"SELECT libelle FROM Grade";
                    cmd = new SQLiteCommand(req, this.cx);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string nomGrade = reader.GetString(0);
                        cboGrades.Items.Add(nomGrade);
                    }
                }

                void BtnAnnuler_Click(object sender, EventArgs e)
                {
                    // On annule les changements
                    txtCode.Text = _strBuffer[0];
                    cboGrades.Text = _strBuffer[1];
                    txtCode.Enabled = false;
                    cboGrades.Enabled = false;

                    btnAnnuler.Visible = false;
                    btnConfirm.Visible = false;
                }

                void BtnConfirm_Click(object sender, EventArgs e)
                {
                    // On initie la transaction
                    SQLiteTransaction transaction = cx.BeginTransaction();

                    req = $@"UPDATE Pompier SET codeGrade = '{txtCode.Text}' WHERE matricule = {matricule}";
                    SQLiteCommand cmdUpdate = new SQLiteCommand(req, this.cx);
                    cmdUpdate.Transaction = transaction;



                    // On gère la confirmation des changements
                    txtCode.Enabled = false;
                    cboGrades.Enabled = false;

                    btnAnnuler.Visible = false;
                    btnConfirm.Visible = false;

                    grade.ImageLocation = $@"..\..\..\..\Ressources\images\ImagesGrades\{txtCode.Text}.png";
                    grade.Load();

                    lblGrade.Text = $"Grade : \n{cboGrades.Text}";

                    // On met à jour les informations dans la DB
                    try
                    {
                        cmdUpdate.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Changements confirmés");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                    }
                }
            }
            else
            {
                Label lblExplicationPompier = new Label();
                lblExplicationPompier.Font = new Font("Arial", 45, FontStyle.Bold, GraphicsUnit.Pixel);
                lblExplicationPompier.TextAlign = ContentAlignment.MiddleCenter;
                lblExplicationPompier.Top = 180;
                lblExplicationPompier.Left = 450;
                lblExplicationPompier.Width = 600;
                lblExplicationPompier.Height = 300;
                lblExplicationPompier.Text = "Sélectionnez un pompier pour afficher ses informations.";

                pnlGestion.Controls.Add(lblExplicationPompier);
            }
        }

        // Boutons pour afficher des informations supplémentaires sur la carrière du pompier
        private void btnPlusInfos_Click(object sender, EventArgs e)
        {

            _intBuffer[1] = originalState();

            int compteur = 0;

            btnPlusInfos.Visible = false;
            grpInfosCarriere.Visible = true;

            for (int i = 0; i < cboCasernes.Items.Count; i++)
            {
                cboChoixCaserne.Items.Add(cboCasernes.Items[i]);
            }
            cboChoixCaserne.Text = cboCasernes.Text;

            string reqHabilitationPasses = $@"SELECT h.libelle
                                              FROM Habilitation h
                                              JOIN Passer pass ON h.id = pass.idHabilitation
                                              JOIN Pompier p ON p.matricule = pass.matriculePompier
                                              WHERE p.matricule = {matricule}";

            string reqHabilitations = "SELECT libelle FROM Habilitation";

            string reqAncienneCasernes = $@"SELECT c.nom, aff.dateA, COALESCE(aff.dateFin, 'Aucune')
                                            FROM Affectation aff
                                            JOIN Caserne c ON aff.idCaserne = c.id
                                            JOIN Pompier p ON aff.matriculePompier = p.matricule
                                            WHERE p.matricule = {matricule}";

            string enConge = $"SELECT enConge FROM Pompier WHERE matricule = {matricule}";

            SQLiteCommand cmdHabilitationPasses = new SQLiteCommand(reqHabilitationPasses, this.cx);
            SQLiteCommand cmdHabilitations = new SQLiteCommand(reqHabilitations, this.cx);
            SQLiteCommand cmdAncienneCasernes = new SQLiteCommand(reqAncienneCasernes, this.cx);
            SQLiteCommand cmdEnConge = new SQLiteCommand(enConge, this.cx);
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

            while(readerEnConge.Read())
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

        }

        private void btnConfirmerMaj_Click(object sender, EventArgs e)
        {
            List<string> habilitations = new List<string>();

            int compteur = _intBuffer[0];

            string req = "";

            int enConge = 0;
            int originalState = _intBuffer[1];
            bool congeBool = originalState == 1;

            if (ckbConge.Checked != congeBool)
            {
                SQLiteCommand cmdConge = new SQLiteCommand(req, this.cx);
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

                req = $"UPDATE Pompier SET enConge = {enConge} WHERE matricule = {matricule}";
                cmdConge.CommandText = req;

                try
                {
                    cmdConge.ExecuteNonQuery();
                    transactionConge.Commit();
                    MessageBox.Show("Changements confirmés");
                }
                catch (Exception ex)
                {
                    transactionConge.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }

            }

            if (chklstHabilitations.CheckedItems.Count > compteur)
            {
                SQLiteCommand cmdHabilitations = new SQLiteCommand(req, this.cx);
                SQLiteTransaction transactionHabilitations = cx.BeginTransaction();
                cmdHabilitations.Transaction = transactionHabilitations;

                for (int i = compteur; i < chklstHabilitations.CheckedItems.Count; i++)
                {
                    habilitations.Add(chklstHabilitations.CheckedItems[i].ToString());
                }

                for (int i = 0; i < chklstHabilitations.CheckedItems.Count - compteur; i++)
                {
                    req = "INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention) " +
                          $"VALUES ((SELECT matricule FROM Pompier WHERE matricule = {matricule}), " +
                          $"(SELECT id FROM Habilitation WHERE lower(libelle) = \"{habilitations[i].ToLower()}\"), " +
                          $"'{DateTime.Today.ToString("yyyy-MM-dd")}')";

                    cmdHabilitations.CommandText = req;

                    cmdHabilitations.ExecuteNonQuery();
                }
                try
                {
                    transactionHabilitations.Commit();
                    MessageBox.Show("Changements confirmés");
                }
                catch (SQLiteException ex)
                {
                    transactionHabilitations.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }
            }

            if (cboCasernes.Text != cboChoixCaserne.Text)
            {
                SQLiteCommand cmdCaserne = new SQLiteCommand(req, this.cx);
                SQLiteTransaction transactionCaserne = cx.BeginTransaction();

                req = $@"UPDATE Affectation SET dateFin = '{DateTime.Today.ToString("yyyy-MM-dd")}'
                      WHERE matriculePompier = (SELECT matricule FROM Pompier WHERE matricule = {matricule});
                      
                      INSERT INTO Affectation (matriculePompier, dateA, idCaserne)
                      VALUES ((SELECT matricule FROM Pompier WHERE matricule = {matricule}),
                      '{DateTime.Today:yyyy-MM-dd}', (SELECT id FROM Caserne WHERE lower(nom) = '{cboChoixCaserne.Text.ToLower()}'))";

                cmdCaserne.CommandText = req;
                cmdCaserne.Transaction = transactionCaserne;
                try
                {
                    cmdCaserne.ExecuteNonQuery();
                    transactionCaserne.Commit();
                    MessageBox.Show("Changements confirmés");
                }
                catch (SQLiteException ex)
                {
                    transactionCaserne.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }
            }
            ChargercboCasernes();
            ChargercboPompiers();
        }

        private void clearAll()
        {
            grpInfosPerso.Controls.Clear();
            grpInfosPompier.Visible = false;

            btnPlusInfos.Visible = true;
            grpInfosCarriere.Visible = false;
            cboChoixCaserne.Items.Clear();
            chklstHabilitations.Items.Clear();
            lstAnciennesCasernes.Items.Clear();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            grpInfosCarriere.Visible = false;
            lstAnciennesCasernes.Items.Clear();
            chklstHabilitations.Items.Clear();
            ckbConge.Checked = false;

            btnPlusInfos.Visible = true;
        }

        // On créer un nouveau formulaire pour l'ajout d'un pompier dans la DB
        private void pcbIconeNouveau_Click(object sender, EventArgs e)
        {
            frmAjoutPompier ajouterPimpon = new frmAjoutPompier();
            if (ajouterPimpon.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Changements confirmés");
            }
            else
            {
                MessageBox.Show("Changements abandonnés");
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
    }
}
