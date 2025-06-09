namespace ExtinctHeure
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.grbVolet2 = new System.Windows.Forms.GroupBox();
            this.grbEP = new System.Windows.Forms.GroupBox();
            this.lblDteMis = new System.Windows.Forms.Label();
            this.lblNumMis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboCasMob = new System.Windows.Forms.ComboBox();
            this.cboNatSin = new System.Windows.Forms.ComboBox();
            this.btnConstEqu = new System.Windows.Forms.Button();
            this.btnAnn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlGestion = new System.Windows.Forms.Panel();
            this.pnlInfosPompiers = new System.Windows.Forms.Panel();
            this.pcbIconeNouveau = new System.Windows.Forms.PictureBox();
            this.cboPompiersSansCaserne = new System.Windows.Forms.ComboBox();
            this.lblPompiersSansCaserne = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.cboPompiers = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.lblNouveauPompier = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblPlusPompier = new System.Windows.Forms.Label();
            this.grpInfosPompier = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpInfosCarriere = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.chklstHabilitations = new System.Windows.Forms.CheckedListBox();
            this.ckbConge = new System.Windows.Forms.CheckBox();
            this.lblAncienneCasernes = new System.Windows.Forms.Label();
            this.btnConfirmerMaj = new System.Windows.Forms.Button();
            this.lstAnciennesCasernes = new System.Windows.Forms.ListView();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.cboChoixCaserne = new System.Windows.Forms.ComboBox();
            this.lblRattachement = new System.Windows.Forms.Label();
            this.grpInfosPerso = new System.Windows.Forms.GroupBox();
            this.pnlMissions = new System.Windows.Forms.Panel();
            this.grpMissions = new System.Windows.Forms.GroupBox();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.grpStat = new System.Windows.Forms.GroupBox();
            this.statsEnginPlusUtiliseHeure = new ExtinctHeureUC.Stats();
            this.statsPompierHabilitation = new ExtinctHeureUC.Stats();
            this.statsHabilitationDemandee = new ExtinctHeureUC.Stats();
            this.statsInterventionSinistre = new ExtinctHeureUC.Stats();
            this.statsEnginPlusUtilise = new ExtinctHeureUC.Stats();
            this.cboHabilitation = new System.Windows.Forms.ComboBox();
            this.lblParCaserne = new System.Windows.Forms.Label();
            this.lblTouteCaserne = new System.Windows.Forms.Label();
            this.lblEnginNbHeure = new System.Windows.Forms.Label();
            this.lblListeHabilitation = new System.Windows.Forms.Label();
            this.lblHabilitationDemandee = new System.Windows.Forms.Label();
            this.lblTypeSinistre = new System.Windows.Forms.Label();
            this.lblEnginNbUtilisation = new System.Windows.Forms.Label();
            this.cboCaserneStat = new System.Windows.Forms.ComboBox();
            this.grbVolet2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTxt)).BeginInit();
            this.pnlGestion.SuspendLayout();
            this.pnlInfosPompiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.grpInfosPompier.SuspendLayout();
            this.grpInfosCarriere.SuspendLayout();
            this.grpMissions.SuspendLayout();
            this.grpStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbVolet2
            // 
            this.grbVolet2.Controls.Add(this.grbEP);
            this.grbVolet2.Controls.Add(this.lblDteMis);
            this.grbVolet2.Controls.Add(this.lblNumMis);
            this.grbVolet2.Controls.Add(this.groupBox3);
            this.grbVolet2.Controls.Add(this.groupBox2);
            this.grbVolet2.Location = new System.Drawing.Point(50, 65);
            this.grbVolet2.Name = "grbVolet2";
            this.grbVolet2.Size = new System.Drawing.Size(38, 20);
            this.grbVolet2.TabIndex = 0;
            this.grbVolet2.TabStop = false;
            this.grbVolet2.Visible = false;
            // 
            // grbEP
            // 
            this.grbEP.Location = new System.Drawing.Point(34, 319);
            this.grbEP.Name = "grbEP";
            this.grbEP.Size = new System.Drawing.Size(1315, 277);
            this.grbEP.TabIndex = 5;
            this.grbEP.TabStop = false;
            this.grbEP.Text = "Mobilisation des engins et des pompiers";
            // 
            // lblDteMis
            // 
            this.lblDteMis.AutoSize = true;
            this.lblDteMis.Location = new System.Drawing.Point(814, 26);
            this.lblDteMis.Name = "lblDteMis";
            this.lblDteMis.Size = new System.Drawing.Size(110, 17);
            this.lblDteMis.TabIndex = 4;
            this.lblDteMis.Text = "déclenchée le : ";
            // 
            // lblNumMis
            // 
            this.lblNumMis.AutoSize = true;
            this.lblNumMis.Location = new System.Drawing.Point(307, 26);
            this.lblNumMis.Name = "lblNumMis";
            this.lblNumMis.Size = new System.Drawing.Size(75, 17);
            this.lblNumMis.TabIndex = 3;
            this.lblNumMis.Text = "Mission n°";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboCasMob);
            this.groupBox3.Controls.Add(this.cboNatSin);
            this.groupBox3.Controls.Add(this.btnConstEqu);
            this.groupBox3.Controls.Add(this.btnAnn);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(34, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1315, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Décisions du régulateur";
            // 
            // cboCasMob
            // 
            this.cboCasMob.FormattingEnabled = true;
            this.cboCasMob.Location = new System.Drawing.Point(706, 47);
            this.cboCasMob.Name = "cboCasMob";
            this.cboCasMob.Size = new System.Drawing.Size(220, 25);
            this.cboCasMob.TabIndex = 9;
            // 
            // cboNatSin
            // 
            this.cboNatSin.FormattingEnabled = true;
            this.cboNatSin.Location = new System.Drawing.Point(201, 47);
            this.cboNatSin.Name = "cboNatSin";
            this.cboNatSin.Size = new System.Drawing.Size(220, 25);
            this.cboNatSin.TabIndex = 8;
            // 
            // btnConstEqu
            // 
            this.btnConstEqu.Location = new System.Drawing.Point(1159, 26);
            this.btnConstEqu.Name = "btnConstEqu";
            this.btnConstEqu.Size = new System.Drawing.Size(139, 57);
            this.btnConstEqu.TabIndex = 10;
            this.btnConstEqu.Text = "Constituer équipe";
            this.btnConstEqu.UseVisualStyleBackColor = true;
            this.btnConstEqu.Click += new System.EventHandler(this.btnConstEqu_Click);
            // 
            // btnAnn
            // 
            this.epTxt.SetIconAlignment(this.btnAnn, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.btnAnn.Location = new System.Drawing.Point(1000, 26);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(139, 57);
            this.btnAnn.TabIndex = 11;
            this.btnAnn.Text = "Annuler";
            this.btnAnn.UseVisualStyleBackColor = true;
            this.btnAnn.Click += new System.EventHandler(this.btnAnn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Caserne à mobiliser";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nature du siniste";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVille);
            this.groupBox2.Controls.Add(this.txtCP);
            this.groupBox2.Controls.Add(this.txtRue);
            this.groupBox2.Controls.Add(this.txtMotif);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1315, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations usager";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(858, 115);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(226, 25);
            this.txtVille.TabIndex = 8;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(858, 83);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(226, 25);
            this.txtCP.TabIndex = 7;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(858, 51);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(226, 25);
            this.txtRue.TabIndex = 6;
            this.txtRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRue_KeyPress);
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(313, 51);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(226, 25);
            this.txtMotif.TabIndex = 5;
            this.txtMotif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotif_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse sinistre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motif";
            // 
            // epTxt
            // 
            this.epTxt.ContainerControl = this;
            // 
            // pnlGestion
            // 
            this.pnlGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.pnlGestion.Controls.Add(this.pnlInfosPompiers);
            this.pnlGestion.Controls.Add(this.grpInfosPompier);
            this.pnlGestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlGestion.Location = new System.Drawing.Point(15, 95);
            this.pnlGestion.Name = "pnlGestion";
            this.pnlGestion.Size = new System.Drawing.Size(5, 5);
            this.pnlGestion.TabIndex = 0;
            this.pnlGestion.Visible = false;
            // 
            // pnlInfosPompiers
            // 
            this.pnlInfosPompiers.BackColor = System.Drawing.Color.DarkRed;
            this.pnlInfosPompiers.Controls.Add(this.pcbIconeNouveau);
            this.pnlInfosPompiers.Controls.Add(this.cboPompiersSansCaserne);
            this.pnlInfosPompiers.Controls.Add(this.lblPompiersSansCaserne);
            this.pnlInfosPompiers.Controls.Add(this.pcbIcone);
            this.pnlInfosPompiers.Controls.Add(this.cboCasernes);
            this.pnlInfosPompiers.Controls.Add(this.cboPompiers);
            this.pnlInfosPompiers.Controls.Add(this.lblPompier);
            this.pnlInfosPompiers.Controls.Add(this.lblNouveauPompier);
            this.pnlInfosPompiers.Controls.Add(this.lblCaserne);
            this.pnlInfosPompiers.Controls.Add(this.lblPlusPompier);
            this.pnlInfosPompiers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlInfosPompiers.Location = new System.Drawing.Point(33, 35);
            this.pnlInfosPompiers.Name = "pnlInfosPompiers";
            this.pnlInfosPompiers.Size = new System.Drawing.Size(275, 675);
            this.pnlInfosPompiers.TabIndex = 6;
            // 
            // pcbIconeNouveau
            // 
            this.pcbIconeNouveau.BackColor = System.Drawing.Color.Transparent;
            this.pcbIconeNouveau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbIconeNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbIconeNouveau.Image = ((System.Drawing.Image)(resources.GetObject("pcbIconeNouveau.Image")));
            this.pcbIconeNouveau.Location = new System.Drawing.Point(125, 420);
            this.pcbIconeNouveau.Name = "pcbIconeNouveau";
            this.pcbIconeNouveau.Size = new System.Drawing.Size(100, 100);
            this.pcbIconeNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIconeNouveau.TabIndex = 4;
            this.pcbIconeNouveau.TabStop = false;
            this.pcbIconeNouveau.Click += new System.EventHandler(this.pcbIconeNouveau_Click);
            // 
            // cboPompiersSansCaserne
            // 
            this.cboPompiersSansCaserne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPompiersSansCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPompiersSansCaserne.FormattingEnabled = true;
            this.cboPompiersSansCaserne.Location = new System.Drawing.Point(19, 345);
            this.cboPompiersSansCaserne.Name = "cboPompiersSansCaserne";
            this.cboPompiersSansCaserne.Size = new System.Drawing.Size(237, 25);
            this.cboPompiersSansCaserne.TabIndex = 6;
            this.cboPompiersSansCaserne.SelectionChangeCommitted += new System.EventHandler(this.cboPompiersSansCaserne_SelectionChangeCommitted);
            // 
            // lblPompiersSansCaserne
            // 
            this.lblPompiersSansCaserne.AutoSize = true;
            this.lblPompiersSansCaserne.ForeColor = System.Drawing.Color.Transparent;
            this.lblPompiersSansCaserne.Location = new System.Drawing.Point(49, 305);
            this.lblPompiersSansCaserne.Name = "lblPompiersSansCaserne";
            this.lblPompiersSansCaserne.Size = new System.Drawing.Size(176, 17);
            this.lblPompiersSansCaserne.TabIndex = 5;
            this.lblPompiersSansCaserne.Text = "Pompiers sans caserne : ";
            // 
            // pcbIcone
            // 
            this.pcbIcone.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcone.Image")));
            this.pcbIcone.Location = new System.Drawing.Point(100, 15);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(75, 75);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcone.TabIndex = 1;
            this.pcbIcone.TabStop = false;
            // 
            // cboCasernes
            // 
            this.cboCasernes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCasernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(19, 165);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(237, 25);
            this.cboCasernes.TabIndex = 1;
            this.cboCasernes.SelectionChangeCommitted += new System.EventHandler(this.cboCasernes_SelectionChangeCommitted);
            // 
            // cboPompiers
            // 
            this.cboPompiers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPompiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPompiers.FormattingEnabled = true;
            this.cboPompiers.Location = new System.Drawing.Point(19, 255);
            this.cboPompiers.Name = "cboPompiers";
            this.cboPompiers.Size = new System.Drawing.Size(237, 25);
            this.cboPompiers.TabIndex = 3;
            this.cboPompiers.Visible = false;
            this.cboPompiers.SelectionChangeCommitted += new System.EventHandler(this.cboPompiers_SelectionChangeCommitted);
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.ForeColor = System.Drawing.Color.Transparent;
            this.lblPompier.Location = new System.Drawing.Point(43, 215);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(189, 17);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Veuillez choisir un pompier :";
            this.lblPompier.Visible = false;
            // 
            // lblNouveauPompier
            // 
            this.lblNouveauPompier.AutoSize = true;
            this.lblNouveauPompier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNouveauPompier.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblNouveauPompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNouveauPompier.Location = new System.Drawing.Point(7, 545);
            this.lblNouveauPompier.Name = "lblNouveauPompier";
            this.lblNouveauPompier.Size = new System.Drawing.Size(260, 21);
            this.lblNouveauPompier.TabIndex = 1;
            this.lblNouveauPompier.Text = "Ajouter un nouveau pompier";
            this.lblNouveauPompier.Click += new System.EventHandler(this.pcbIconeNouveau_Click);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.ForeColor = System.Drawing.Color.Transparent;
            this.lblCaserne.Location = new System.Drawing.Point(39, 125);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(197, 17);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Veuillez choisir une caserne :";
            // 
            // lblPlusPompier
            // 
            this.lblPlusPompier.BackColor = System.Drawing.Color.Transparent;
            this.lblPlusPompier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlusPompier.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusPompier.ForeColor = System.Drawing.Color.White;
            this.lblPlusPompier.Location = new System.Drawing.Point(25, 420);
            this.lblPlusPompier.Name = "lblPlusPompier";
            this.lblPlusPompier.Size = new System.Drawing.Size(100, 100);
            this.lblPlusPompier.TabIndex = 7;
            this.lblPlusPompier.Text = "+";
            this.lblPlusPompier.Click += new System.EventHandler(this.pcbIconeNouveau_Click);
            // 
            // grpInfosPompier
            // 
            this.grpInfosPompier.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grpInfosPompier.Controls.Add(this.btnLogin);
            this.grpInfosPompier.Controls.Add(this.grpInfosCarriere);
            this.grpInfosPompier.Controls.Add(this.grpInfosPerso);
            this.grpInfosPompier.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpInfosPompier.Location = new System.Drawing.Point(401, 27);
            this.grpInfosPompier.Name = "grpInfosPompier";
            this.grpInfosPompier.Size = new System.Drawing.Size(770, 700);
            this.grpInfosPompier.TabIndex = 5;
            this.grpInfosPompier.TabStop = false;
            this.grpInfosPompier.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Location = new System.Drawing.Point(235, 390);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Se connecter pour modifier les informations";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpInfosCarriere
            // 
            this.grpInfosCarriere.Controls.Add(this.btnAnnuler);
            this.grpInfosCarriere.Controls.Add(this.chklstHabilitations);
            this.grpInfosCarriere.Controls.Add(this.ckbConge);
            this.grpInfosCarriere.Controls.Add(this.lblAncienneCasernes);
            this.grpInfosCarriere.Controls.Add(this.btnConfirmerMaj);
            this.grpInfosCarriere.Controls.Add(this.lstAnciennesCasernes);
            this.grpInfosCarriere.Controls.Add(this.lblHabilitations);
            this.grpInfosCarriere.Controls.Add(this.cboChoixCaserne);
            this.grpInfosCarriere.Controls.Add(this.lblRattachement);
            this.grpInfosCarriere.ForeColor = System.Drawing.SystemColors.Window;
            this.grpInfosCarriere.Location = new System.Drawing.Point(17, 413);
            this.grpInfosCarriere.Name = "grpInfosCarriere";
            this.grpInfosCarriere.Size = new System.Drawing.Size(740, 280);
            this.grpInfosCarriere.TabIndex = 3;
            this.grpInfosCarriere.TabStop = false;
            this.grpInfosCarriere.Text = "Gérer les informations de la carrière";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAnnuler.Location = new System.Drawing.Point(504, 244);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(103, 26);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // chklstHabilitations
            // 
            this.chklstHabilitations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chklstHabilitations.Enabled = false;
            this.chklstHabilitations.FormattingEnabled = true;
            this.chklstHabilitations.Location = new System.Drawing.Point(433, 101);
            this.chklstHabilitations.Name = "chklstHabilitations";
            this.chklstHabilitations.Size = new System.Drawing.Size(300, 124);
            this.chklstHabilitations.TabIndex = 9;
            // 
            // ckbConge
            // 
            this.ckbConge.AutoSize = true;
            this.ckbConge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbConge.Enabled = false;
            this.ckbConge.Location = new System.Drawing.Point(433, 41);
            this.ckbConge.Name = "ckbConge";
            this.ckbConge.Size = new System.Drawing.Size(89, 21);
            this.ckbConge.TabIndex = 7;
            this.ckbConge.Text = "En congé";
            this.ckbConge.UseVisualStyleBackColor = true;
            // 
            // lblAncienneCasernes
            // 
            this.lblAncienneCasernes.AutoSize = true;
            this.lblAncienneCasernes.Location = new System.Drawing.Point(20, 75);
            this.lblAncienneCasernes.Name = "lblAncienneCasernes";
            this.lblAncienneCasernes.Size = new System.Drawing.Size(167, 17);
            this.lblAncienneCasernes.TabIndex = 6;
            this.lblAncienneCasernes.Text = "Anciennes affectations : ";
            // 
            // btnConfirmerMaj
            // 
            this.btnConfirmerMaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmerMaj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnConfirmerMaj.Location = new System.Drawing.Point(630, 244);
            this.btnConfirmerMaj.Name = "btnConfirmerMaj";
            this.btnConfirmerMaj.Size = new System.Drawing.Size(103, 26);
            this.btnConfirmerMaj.TabIndex = 4;
            this.btnConfirmerMaj.Text = "Mettre à jour";
            this.btnConfirmerMaj.UseVisualStyleBackColor = true;
            this.btnConfirmerMaj.Visible = false;
            this.btnConfirmerMaj.Click += new System.EventHandler(this.btnConfirmerMaj_Click);
            // 
            // lstAnciennesCasernes
            // 
            this.lstAnciennesCasernes.Enabled = false;
            this.lstAnciennesCasernes.HideSelection = false;
            this.lstAnciennesCasernes.Location = new System.Drawing.Point(20, 105);
            this.lstAnciennesCasernes.Name = "lstAnciennesCasernes";
            this.lstAnciennesCasernes.Size = new System.Drawing.Size(360, 133);
            this.lstAnciennesCasernes.TabIndex = 3;
            this.lstAnciennesCasernes.UseCompatibleStateImageBehavior = false;
            this.lstAnciennesCasernes.View = System.Windows.Forms.View.List;
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(430, 75);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(98, 17);
            this.lblHabilitations.TabIndex = 2;
            this.lblHabilitations.Text = "Habilitations : ";
            // 
            // cboChoixCaserne
            // 
            this.cboChoixCaserne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChoixCaserne.Enabled = false;
            this.cboChoixCaserne.FormattingEnabled = true;
            this.cboChoixCaserne.Location = new System.Drawing.Point(185, 42);
            this.cboChoixCaserne.Name = "cboChoixCaserne";
            this.cboChoixCaserne.Size = new System.Drawing.Size(195, 25);
            this.cboChoixCaserne.TabIndex = 1;
            // 
            // lblRattachement
            // 
            this.lblRattachement.AutoSize = true;
            this.lblRattachement.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRattachement.Location = new System.Drawing.Point(20, 45);
            this.lblRattachement.Name = "lblRattachement";
            this.lblRattachement.Size = new System.Drawing.Size(163, 17);
            this.lblRattachement.TabIndex = 0;
            this.lblRattachement.Text = "Rattaché à la caserne : ";
            // 
            // grpInfosPerso
            // 
            this.grpInfosPerso.ForeColor = System.Drawing.Color.White;
            this.grpInfosPerso.Location = new System.Drawing.Point(17, 14);
            this.grpInfosPerso.Name = "grpInfosPerso";
            this.grpInfosPerso.Size = new System.Drawing.Size(740, 375);
            this.grpInfosPerso.TabIndex = 2;
            this.grpInfosPerso.TabStop = false;
            // 
            // pnlMissions
            // 
            this.pnlMissions.AutoScroll = true;
            this.pnlMissions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMissions.Location = new System.Drawing.Point(3, -580);
            this.pnlMissions.Name = "pnlMissions";
            this.pnlMissions.Size = new System.Drawing.Size(32, 601);
            this.pnlMissions.TabIndex = 1;
            // 
            // grpMissions
            // 
            this.grpMissions.Controls.Add(this.chkEnCours);
            this.grpMissions.Controls.Add(this.pnlMissions);
            this.grpMissions.Location = new System.Drawing.Point(67, 101);
            this.grpMissions.Name = "grpMissions";
            this.grpMissions.Size = new System.Drawing.Size(38, 23);
            this.grpMissions.TabIndex = 0;
            this.grpMissions.TabStop = false;
            this.grpMissions.Text = "Missions";
            this.grpMissions.Visible = false;
            this.grpMissions.VisibleChanged += new System.EventHandler(this.grpMissions_VisibleChanged);
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Location = new System.Drawing.Point(64, 38);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(86, 21);
            this.chkEnCours.TabIndex = 2;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.grpMissions_VisibleChanged);
            // 
            // grpStat
            // 
            this.grpStat.Controls.Add(this.statsEnginPlusUtiliseHeure);
            this.grpStat.Controls.Add(this.statsPompierHabilitation);
            this.grpStat.Controls.Add(this.statsHabilitationDemandee);
            this.grpStat.Controls.Add(this.statsInterventionSinistre);
            this.grpStat.Controls.Add(this.statsEnginPlusUtilise);
            this.grpStat.Controls.Add(this.cboHabilitation);
            this.grpStat.Controls.Add(this.lblParCaserne);
            this.grpStat.Controls.Add(this.lblTouteCaserne);
            this.grpStat.Controls.Add(this.lblEnginNbHeure);
            this.grpStat.Controls.Add(this.lblListeHabilitation);
            this.grpStat.Controls.Add(this.lblHabilitationDemandee);
            this.grpStat.Controls.Add(this.lblTypeSinistre);
            this.grpStat.Controls.Add(this.lblEnginNbUtilisation);
            this.grpStat.Controls.Add(this.cboCaserneStat);
            this.grpStat.Location = new System.Drawing.Point(111, 90);
            this.grpStat.Name = "grpStat";
            this.grpStat.Size = new System.Drawing.Size(34, 32);
            this.grpStat.TabIndex = 0;
            this.grpStat.TabStop = false;
            this.grpStat.Text = "Statistiques";
            this.grpStat.Visible = false;
            this.grpStat.VisibleChanged += new System.EventHandler(this.grpStat_VisibleChanged);
            // 
            // statsEnginPlusUtiliseHeure
            // 
            this.statsEnginPlusUtiliseHeure.ColonneDroite = "Nombre d\'heure";
            this.statsEnginPlusUtiliseHeure.ColonneGauche = "Nom de l\'engin";
            this.statsEnginPlusUtiliseHeure.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsEnginPlusUtiliseHeure.Location = new System.Drawing.Point(832, 494);
            this.statsEnginPlusUtiliseHeure.Margin = new System.Windows.Forms.Padding(4);
            this.statsEnginPlusUtiliseHeure.Name = "statsEnginPlusUtiliseHeure";
            this.statsEnginPlusUtiliseHeure.Size = new System.Drawing.Size(371, 219);
            this.statsEnginPlusUtiliseHeure.TabIndex = 5;
            // 
            // statsPompierHabilitation
            // 
            this.statsPompierHabilitation.ColonneDroite = "Prénom";
            this.statsPompierHabilitation.ColonneGauche = "Nom";
            this.statsPompierHabilitation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsPompierHabilitation.Location = new System.Drawing.Point(832, 108);
            this.statsPompierHabilitation.Margin = new System.Windows.Forms.Padding(4);
            this.statsPompierHabilitation.Name = "statsPompierHabilitation";
            this.statsPompierHabilitation.Size = new System.Drawing.Size(371, 219);
            this.statsPompierHabilitation.TabIndex = 5;
            // 
            // statsHabilitationDemandee
            // 
            this.statsHabilitationDemandee.ColonneDroite = "Nombre de demande";
            this.statsHabilitationDemandee.ColonneGauche = "Habilitation";
            this.statsHabilitationDemandee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsHabilitationDemandee.Location = new System.Drawing.Point(428, 108);
            this.statsHabilitationDemandee.Margin = new System.Windows.Forms.Padding(4);
            this.statsHabilitationDemandee.Name = "statsHabilitationDemandee";
            this.statsHabilitationDemandee.Size = new System.Drawing.Size(371, 219);
            this.statsHabilitationDemandee.TabIndex = 5;
            // 
            // statsInterventionSinistre
            // 
            this.statsInterventionSinistre.ColonneDroite = "Nombre d\'interventions";
            this.statsInterventionSinistre.ColonneGauche = "Nature du sinistre";
            this.statsInterventionSinistre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsInterventionSinistre.Location = new System.Drawing.Point(22, 108);
            this.statsInterventionSinistre.Margin = new System.Windows.Forms.Padding(4);
            this.statsInterventionSinistre.Name = "statsInterventionSinistre";
            this.statsInterventionSinistre.Size = new System.Drawing.Size(371, 219);
            this.statsInterventionSinistre.TabIndex = 5;
            // 
            // statsEnginPlusUtilise
            // 
            this.statsEnginPlusUtilise.ColonneDroite = "Nombre d\'utilisation";
            this.statsEnginPlusUtilise.ColonneGauche = "Nom de l\'engin";
            this.statsEnginPlusUtilise.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsEnginPlusUtilise.Location = new System.Drawing.Point(22, 494);
            this.statsEnginPlusUtilise.Margin = new System.Windows.Forms.Padding(4);
            this.statsEnginPlusUtilise.Name = "statsEnginPlusUtilise";
            this.statsEnginPlusUtilise.Size = new System.Drawing.Size(371, 219);
            this.statsEnginPlusUtilise.TabIndex = 5;
            // 
            // cboHabilitation
            // 
            this.cboHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHabilitation.FormattingEnabled = true;
            this.cboHabilitation.Location = new System.Drawing.Point(832, 334);
            this.cboHabilitation.Name = "cboHabilitation";
            this.cboHabilitation.Size = new System.Drawing.Size(355, 25);
            this.cboHabilitation.TabIndex = 4;
            this.cboHabilitation.SelectedIndexChanged += new System.EventHandler(this.cboHabilitation_SelectedIndexChanged);
            // 
            // lblParCaserne
            // 
            this.lblParCaserne.AutoSize = true;
            this.lblParCaserne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParCaserne.Location = new System.Drawing.Point(550, 377);
            this.lblParCaserne.Name = "lblParCaserne";
            this.lblParCaserne.Size = new System.Drawing.Size(112, 22);
            this.lblParCaserne.TabIndex = 3;
            this.lblParCaserne.Text = "Par caserne";
            // 
            // lblTouteCaserne
            // 
            this.lblTouteCaserne.AutoSize = true;
            this.lblTouteCaserne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTouteCaserne.Location = new System.Drawing.Point(515, 52);
            this.lblTouteCaserne.Name = "lblTouteCaserne";
            this.lblTouteCaserne.Size = new System.Drawing.Size(180, 22);
            this.lblTouteCaserne.TabIndex = 3;
            this.lblTouteCaserne.Text = "Toutes les casernes";
            // 
            // lblEnginNbHeure
            // 
            this.lblEnginNbHeure.AutoSize = true;
            this.lblEnginNbHeure.Location = new System.Drawing.Point(877, 473);
            this.lblEnginNbHeure.Name = "lblEnginNbHeure";
            this.lblEnginNbHeure.Size = new System.Drawing.Size(262, 17);
            this.lblEnginNbHeure.TabIndex = 2;
            this.lblEnginNbHeure.Text = "Nombre d\'heure d\'utilisation des engins";
            // 
            // lblListeHabilitation
            // 
            this.lblListeHabilitation.AutoSize = true;
            this.lblListeHabilitation.Location = new System.Drawing.Point(933, 87);
            this.lblListeHabilitation.Name = "lblListeHabilitation";
            this.lblListeHabilitation.Size = new System.Drawing.Size(168, 17);
            this.lblListeHabilitation.TabIndex = 2;
            this.lblListeHabilitation.Text = "Pompiers par habilitation";
            // 
            // lblHabilitationDemandee
            // 
            this.lblHabilitationDemandee.AutoSize = true;
            this.lblHabilitationDemandee.Location = new System.Drawing.Point(498, 88);
            this.lblHabilitationDemandee.Name = "lblHabilitationDemandee";
            this.lblHabilitationDemandee.Size = new System.Drawing.Size(221, 17);
            this.lblHabilitationDemandee.TabIndex = 2;
            this.lblHabilitationDemandee.Text = "Habilitations les plus demandées";
            // 
            // lblTypeSinistre
            // 
            this.lblTypeSinistre.AutoSize = true;
            this.lblTypeSinistre.Location = new System.Drawing.Point(55, 88);
            this.lblTypeSinistre.Name = "lblTypeSinistre";
            this.lblTypeSinistre.Size = new System.Drawing.Size(284, 17);
            this.lblTypeSinistre.TabIndex = 2;
            this.lblTypeSinistre.Text = "Nombre d\'interventions par type de sinistre";
            // 
            // lblEnginNbUtilisation
            // 
            this.lblEnginNbUtilisation.AutoSize = true;
            this.lblEnginNbUtilisation.Location = new System.Drawing.Point(90, 473);
            this.lblEnginNbUtilisation.Name = "lblEnginNbUtilisation";
            this.lblEnginNbUtilisation.Size = new System.Drawing.Size(210, 17);
            this.lblEnginNbUtilisation.TabIndex = 2;
            this.lblEnginNbUtilisation.Text = "Nombre d\'utilisation des engins";
            // 
            // cboCaserneStat
            // 
            this.cboCaserneStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserneStat.FormattingEnabled = true;
            this.cboCaserneStat.Location = new System.Drawing.Point(480, 402);
            this.cboCaserneStat.Name = "cboCaserneStat";
            this.cboCaserneStat.Size = new System.Drawing.Size(239, 25);
            this.cboCaserneStat.TabIndex = 0;
            this.cboCaserneStat.SelectedIndexChanged += new System.EventHandler(this.cboCaserneStat_SelectedIndexChanged);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.pnlGestion);
            this.Controls.Add(this.grbVolet2);
            this.Controls.Add(this.grpMissions);
            this.Controls.Add(this.grpStat);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extinct\'Heure";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grbVolet2.ResumeLayout(false);
            this.grbVolet2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTxt)).EndInit();
            this.pnlGestion.ResumeLayout(false);
            this.pnlInfosPompiers.ResumeLayout(false);
            this.pnlInfosPompiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.grpInfosPompier.ResumeLayout(false);
            this.grpInfosCarriere.ResumeLayout(false);
            this.grpInfosCarriere.PerformLayout();
            this.grpMissions.ResumeLayout(false);
            this.grpMissions.PerformLayout();
            this.grpStat.ResumeLayout(false);
            this.grpStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVolet2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDteMis;
        private System.Windows.Forms.Label lblNumMis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConstEqu;
        private System.Windows.Forms.Button btnAnn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.ComboBox cboCasMob;
        private System.Windows.Forms.ComboBox cboNatSin;
        private System.Windows.Forms.GroupBox grbEP;
        private System.Windows.Forms.ErrorProvider epTxt;
        private System.Windows.Forms.Panel pnlGestion;
        private System.Windows.Forms.Panel pnlInfosPompiers;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.ComboBox cboCasernes;
        private System.Windows.Forms.ComboBox cboPompiers;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.Label lblNouveauPompier;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.CheckBox ckbConge;
        private System.Windows.Forms.Label lblAncienneCasernes;
        private System.Windows.Forms.Button btnConfirmerMaj;
        private System.Windows.Forms.ListView lstAnciennesCasernes;
        private System.Windows.Forms.Label lblHabilitations;
        private System.Windows.Forms.ComboBox cboChoixCaserne;
        private System.Windows.Forms.Label lblRattachement;
        private System.Windows.Forms.CheckedListBox chklstHabilitations;
        private System.Windows.Forms.ComboBox cboPompiersSansCaserne;
        private System.Windows.Forms.Label lblPompiersSansCaserne;
        private System.Windows.Forms.PictureBox pcbIconeNouveau;
        public System.Windows.Forms.Button btnLogin;
        protected System.Windows.Forms.GroupBox grpInfosCarriere;
        public System.Windows.Forms.GroupBox grpInfosPerso;
        public System.Windows.Forms.GroupBox grpInfosPompier;
        private System.Windows.Forms.Label lblPlusPompier;
        private System.Windows.Forms.Button btnAnnuler;

        // VOLET 1

        private System.Windows.Forms.Panel pnlMissions;
        private System.Windows.Forms.GroupBox grpMissions;
        private System.Windows.Forms.CheckBox chkEnCours;

        // VOLET 5

        private System.Windows.Forms.GroupBox grpStat;
        private System.Windows.Forms.ComboBox cboCaserneStat;
        private System.Windows.Forms.Label lblEnginNbUtilisation;
        private System.Windows.Forms.Label lblEnginNbHeure;
        private System.Windows.Forms.Label lblTouteCaserne;
        private System.Windows.Forms.Label lblTypeSinistre;
        private System.Windows.Forms.Label lblListeHabilitation;
        private System.Windows.Forms.ComboBox cboHabilitation;
        private System.Windows.Forms.Label lblHabilitationDemandee;
        private ExtinctHeureUC.Stats statsEnginPlusUtiliseHeure;
        private ExtinctHeureUC.Stats statsEnginPlusUtilise;
        private ExtinctHeureUC.Stats statsInterventionSinistre;
        private ExtinctHeureUC.Stats statsHabilitationDemandee;
        private ExtinctHeureUC.Stats statsPompierHabilitation;
        private System.Windows.Forms.Label lblParCaserne;
    }
}

