using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Pinpon;

namespace ExtinctHeure
{
    public partial class frmAccueil : Form
    {
        private List<string> _strBuffer = new List<string>(20);
        private int[] _intBuffer = new int[10];
        private readonly SQLiteConnection _cx;
        private bool isAlreadyConnected = false;

        private int _matricule = 0;
        private Button _btnChangeGrade;
        private Button _btnAnnulerGrade;
        private Button _btnConfirmGrade;
        public frmAccueil()
        {
            InitializeComponent();
            try
            {
                this._cx = Connexion.Connec;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de l'accès à la DB : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // On charge uniquement la combobox des Casernes dans le load
        private void frmAccueil_Load(object sender, EventArgs e)
        {
            chargerCboCasernes(cboCasernes);
        }

        // Une fois une caserne choisi on récupère les pompiers associés à cette caserne
        private void cboCasernes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearAll();
            cboPompiers.Text = String.Empty;
            cboPompiersSansCaserne.Text = String.Empty;

            if (cboCasernes.SelectedIndex != -1)
            {
                lblPompier.Visible = true;
                cboPompiers.Visible = true;
                lblPompiersSansCaserne.Visible = true;
                cboPompiersSansCaserne.Visible = true;
                chargerCboPompiersSansCaserne();
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

        // Fonctions pour charger les Casernes et les Pompiers dans la combobox
        private void chargerCboCasernes(ComboBox cbo)
        {
            string req = "SELECT nom, id AS idCaserne FROM Caserne";

            SQLiteDataAdapter daCaserne = new SQLiteDataAdapter(req, this._cx);
            DataTable dtCasernes = new DataTable();

            daCaserne.Fill(dtCasernes);
            cbo.ValueMember = "idCaserne"; // Valeur de la combobox est l'id de la caserne
            cbo.DisplayMember = "nom"; // Affichage du nom de la caserne dans la combobox
            cbo.DataSource = dtCasernes;
            cbo.SelectedIndex = -1; // On ne sélectionne rien par défaut
        }

        private void chargerCboPompiers()
        {
            // On récupère uniquement les pompiers présent dans la caserne choisie
            string req = "SELECT p.nom || ' ' || p.prenom AS NomComplet, p.matricule FROM Pompier p " +
                         "JOIN Affectation a ON p.matricule = a.matriculePompier " +
                         $"JOIN Caserne c ON a.idCaserne = c.id WHERE lower(c.nom) = '{cboCasernes.Text.ToLower()}' " +
                         "AND a.dateFin IS NULL Order by p.nom";

            SQLiteDataAdapter daPompier = new SQLiteDataAdapter(req, this._cx);

            DataTable dtPompiers = new DataTable();

            daPompier.Fill(dtPompiers);
            
            cboPompiers.ValueMember = "matricule"; // Valeur de la combobox est le matricule du pompier
            cboPompiers.DisplayMember = "nomComplet"; // Affichage du nom et prénom dans la combobox
            cboPompiers.DataSource = dtPompiers;
            cboPompiers.SelectedItem = null; // On ne sélectionne rien par défaut
        }

        private void chargerCboPompiersSansCaserne()
        {
            // On récupère uniquement les pompiers présent dans la caserne choisie
            string req = "SELECT p.nom || ' ' || p.prenom AS NomComplet, p.matricule FROM Pompier p " +
                         "JOIN Affectation a ON p.matricule = a.matriculePompier " +
                         "WHERE p.matricule NOT IN (SELECT a.matriculePompier FROM Affectation a WHERE a.dateFin IS NULL)";

            SQLiteDataAdapter daPompier = new SQLiteDataAdapter(req, this._cx);

            DataTable dtPompiers = new DataTable();

            daPompier.Fill(dtPompiers);

            cboPompiersSansCaserne.ValueMember = "matricule"; // Valeur de la combobox est le matricule du pompier
            cboPompiersSansCaserne.DisplayMember = "nomComplet"; // Affichage du nom et prénom dans la combobox
            cboPompiersSansCaserne.DataSource = dtPompiers;
            cboPompiersSansCaserne.SelectedItem = null; // On ne sélectionne rien par défaut
        }

        // On charge les infos des pompiers
        private void ChargerInfosPompiers()
        {
            grpInfosPompier.Visible = false;
            clearAll();
            grpInfosPompier.Visible = true;

            if (cboPompiers.SelectedIndex != -1)
            {
                _matricule = Convert.ToInt32(cboPompiers.SelectedValue);
            }
            else
            {
                _matricule = Convert.ToInt32(cboPompiersSansCaserne.SelectedValue);
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
                Font = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel),
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
                Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
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
                Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
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
                Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
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
            _btnAnnulerGrade.Click += BtnAnnuler_Click;

            // Requête pour remplir les infos persos
            string req = $@"SELECT p.matricule, p.nom, p.prenom, p.sexe, p.dateNaissance, p.type, p.dateEmbauche, p.codeGrade, g.libelle, p.enConge
                            FROM Pompier p JOIN Grade g ON p.codeGrade = g.code WHERE matricule = {_matricule}";
            SQLiteCommand cmd = new SQLiteCommand(req, this._cx);
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
                            valeur = "Homme ♂";
                        else if (pompierReader.GetString(i) == "f")
                            valeur = "Femme ♀";
                        else
                            valeur = pompierReader.GetString(i);
                    }

                    if (labelsPerso[i] == "Matricule")
                    {
                        lbl.Text = $"{labelsPerso[i]} : {valeur}";
                        lbl.Font = new Font("Arial", 26, FontStyle.Bold, GraphicsUnit.Pixel);
                        lbl.Height = 40;
                        lbl.Top = 25;
                        lbl.Left = 250;
                        lbl.Width = lbl.Text.Length * 15;
                        grpInfosPerso.Controls.Add(lbl);
                    }
                    else if (labelsPerso[i] == "Type")
                    {
                        lbl.Text = "Pompier : ";
                        lbl.Top = i * 33;
                        lbl.Left = 10;
                        lbl.Width = 72;
                        lbl.Height = 20;

                        RadioButton rdbProfessionel = new RadioButton
                        {
                            Top = (i * 33) - 2,
                            Left = 82,
                            Text = "Professionel",
                            Width = "Professionel".Length * 10
                        };

                        RadioButton rdbVolontaire = new RadioButton
                        {
                            Top = (i * 33) - 2,
                            Left = 82,
                            Text = "Volontaire"
                        };

                        if (pompierReader.GetString(i) == "p")
                        {
                            rdbProfessionel.Checked = true;
                            rdbVolontaire.Visible = false;
                        }
                        else
                        {
                            rdbVolontaire.Checked = true;
                            rdbProfessionel.Visible = false;
                        }

                        grpInfosPerso.Controls.Add(lbl);
                        grpInfosPerso.Controls.Add(rdbProfessionel);
                        grpInfosPerso.Controls.Add(rdbVolontaire);
                    }
                    else if (labelsPerso[i] == "Code grade")
                    {
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

            cmd = new SQLiteCommand(req, this._cx);
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

            // Méthodes internes
            void cboGrades_SelectedValueChanged(object sender, EventArgs e)
            {
                if (!string.IsNullOrEmpty(cboGrades.Text))
                {
                    req = $@"SELECT code FROM Grade WHERE libelle = '{cboGrades.Text}'";
                    cmd = new SQLiteCommand(req, this._cx);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtCode.Text = reader.GetString(0);
                    }
                }
            }

            void BtnChange_Click(object sender, EventArgs e)
            {
                _btnAnnulerGrade.Visible = true;
                _btnConfirmGrade.Visible = true;

                cboGrades.Text = string.Empty;
                cboGrades.Items.Clear();
                cboGrades.Enabled = true;

                req = "SELECT libelle FROM Grade";
                cmd = new SQLiteCommand(req, this._cx);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nomGrade = reader.GetString(0);
                    cboGrades.Items.Add(nomGrade);
                }
            }

            void BtnAnnuler_Click(object sender, EventArgs e)
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
                SQLiteTransaction transaction = _cx.BeginTransaction();

                req = $@"UPDATE Pompier SET codeGrade = '{txtCode.Text}' WHERE matricule = {_matricule}";
                SQLiteCommand cmdUpdate = new SQLiteCommand(req, this._cx)
                {
                    Transaction = transaction
                };

                txtCode.Enabled = false;
                cboGrades.Enabled = false;
                btnAnnuler.Visible = false;
                _btnConfirmGrade.Visible = false;

                grade.ImageLocation = $@"..\..\..\..\Ressources\images\ImagesGrades\{txtCode.Text}.png";
                grade.Load();
                lblGrade.Text = $"Grade : \n{cboGrades.Text}";

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
        }


        // Boutons pour afficher des informations supplémentaires sur la carrière du pompier
        private void btnPlusInfos_Click(object sender, EventArgs e)
        {
            if (!isAlreadyConnected)
            {
                frmConnexion connexion = new frmConnexion();
                if (connexion.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Vous êtes bien connecté", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAlreadyConnected = true;
                }
                else
                {
                    MessageBox.Show("Accès non autorisé", "Refus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (isAlreadyConnected) {
                chargerCboCasernes(cboChoixCaserne);

                _intBuffer[1] = originalState();

                int compteur = 0;

                btnPlusInfos.Visible = false;
                grpInfosCarriere.Visible = true;
                _btnChangeGrade.Visible = true;

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

                SQLiteCommand cmdHabilitationPasses = new SQLiteCommand(reqHabilitationPasses, this._cx);
                SQLiteCommand cmdHabilitations = new SQLiteCommand(reqHabilitations, this._cx);
                SQLiteCommand cmdAncienneCasernes = new SQLiteCommand(reqAncienneCasernes, this._cx);
                SQLiteCommand cmdEnConge = new SQLiteCommand(enConge, this._cx);
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
            }
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
                SQLiteCommand cmdConge = new SQLiteCommand(req, this._cx);
                SQLiteTransaction transactionConge = _cx.BeginTransaction();
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
                    MessageBox.Show("Changements confirmés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transactionConge.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (chklstHabilitations.CheckedItems.Count > compteur)
            {
                SQLiteCommand cmdHabilitations = new SQLiteCommand(req, this._cx);
                SQLiteTransaction transactionHabilitations = _cx.BeginTransaction();
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

                    cmdHabilitations.ExecuteNonQuery();
                }
                try
                {
                    transactionHabilitations.Commit();
                    MessageBox.Show("Changements confirmés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SQLiteException ex)
                {
                    transactionHabilitations.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cboCasernes.Text != cboChoixCaserne.Text)
            {
                SQLiteCommand cmdCaserne = new SQLiteCommand(req, this._cx);
                SQLiteTransaction transactionCaserne = _cx.BeginTransaction();

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
                    MessageBox.Show("Changements confirmés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SQLiteException ex)
                {
                    transactionCaserne.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            chargerCboCasernes(cboCasernes);
            chargerCboPompiers();
        }

        private void clearAll()
        {
            grpInfosPerso.Controls.Clear();
            grpInfosPompier.Visible = false;

            btnPlusInfos.Visible = true;
            grpInfosCarriere.Visible = false;
            cboChoixCaserne.SelectedIndex = -1;
            chklstHabilitations.Items.Clear();
            lstAnciennesCasernes.Items.Clear();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            grpInfosCarriere.Visible = false;

            _btnChangeGrade.Visible = false;
            _btnAnnulerGrade.Visible = false;
            _btnConfirmGrade.Visible = false;

            lstAnciennesCasernes.Items.Clear();
            chklstHabilitations.Items.Clear();
            ckbConge.Checked = false;

            btnPlusInfos.Visible = true;
        }

        // On créer un nouveau formulaire pour l'ajout d'un pompier dans la DB
        private void pcbIconeNouveau_Click(object sender, EventArgs e)
        {
            if (!isAlreadyConnected)
            {
                frmConnexion connexion = new frmConnexion();
                if (connexion.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Vous êtes bien connecté", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAlreadyConnected = true;

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
                else
                {
                    MessageBox.Show("Accès non autorisé", "Refus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
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
    }
}
