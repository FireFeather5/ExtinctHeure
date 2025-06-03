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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
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
            this.grpInfosPompier = new System.Windows.Forms.GroupBox();
            this.btnPlusInfos = new System.Windows.Forms.Button();
            this.grpInfosCarriere = new System.Windows.Forms.GroupBox();
            this.chklstHabilitations = new System.Windows.Forms.CheckedListBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.ckbConge = new System.Windows.Forms.CheckBox();
            this.lblAncienneCasernes = new System.Windows.Forms.Label();
            this.btnConfirmerMaj = new System.Windows.Forms.Button();
            this.lstAnciennesCasernes = new System.Windows.Forms.ListView();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.cboChoixCaserne = new System.Windows.Forms.ComboBox();
            this.lblRattachement = new System.Windows.Forms.Label();
            this.grpInfosPerso = new System.Windows.Forms.GroupBox();
            this.lblPlusPompier = new System.Windows.Forms.Label();
            this.pnlGestion.SuspendLayout();
            this.pnlInfosPompiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.grpInfosPompier.SuspendLayout();
            this.grpInfosCarriere.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGestion
            // 
            this.pnlGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.pnlGestion.Controls.Add(this.pnlInfosPompiers);
            this.pnlGestion.Controls.Add(this.grpInfosPompier);
            this.pnlGestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlGestion.Location = new System.Drawing.Point(15, 95);
            this.pnlGestion.Name = "pnlGestion";
            this.pnlGestion.Size = new System.Drawing.Size(1205, 755);
            this.pnlGestion.TabIndex = 0;
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
            this.pcbIconeNouveau.BackColor = System.Drawing.Color.White;
            this.pcbIconeNouveau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.cboPompiersSansCaserne.Size = new System.Drawing.Size(237, 24);
            this.cboPompiersSansCaserne.TabIndex = 6;
            this.cboPompiersSansCaserne.Visible = false;
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
            this.lblPompiersSansCaserne.Visible = false;
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
            this.cboCasernes.Size = new System.Drawing.Size(237, 24);
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
            this.cboPompiers.Size = new System.Drawing.Size(237, 24);
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
            // grpInfosPompier
            // 
            this.grpInfosPompier.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grpInfosPompier.Controls.Add(this.btnPlusInfos);
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
            // btnPlusInfos
            // 
            this.btnPlusInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlusInfos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPlusInfos.Location = new System.Drawing.Point(583, 391);
            this.btnPlusInfos.Name = "btnPlusInfos";
            this.btnPlusInfos.Size = new System.Drawing.Size(175, 27);
            this.btnPlusInfos.TabIndex = 4;
            this.btnPlusInfos.Text = "Plus d\'informations";
            this.btnPlusInfos.UseVisualStyleBackColor = true;
            this.btnPlusInfos.Click += new System.EventHandler(this.btnPlusInfos_Click);
            // 
            // grpInfosCarriere
            // 
            this.grpInfosCarriere.Controls.Add(this.chklstHabilitations);
            this.grpInfosCarriere.Controls.Add(this.btnAnnuler);
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
            this.grpInfosCarriere.Visible = false;
            // 
            // chklstHabilitations
            // 
            this.chklstHabilitations.FormattingEnabled = true;
            this.chklstHabilitations.Location = new System.Drawing.Point(430, 65);
            this.chklstHabilitations.Name = "chklstHabilitations";
            this.chklstHabilitations.Size = new System.Drawing.Size(300, 137);
            this.chklstHabilitations.TabIndex = 9;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAnnuler.Location = new System.Drawing.Point(445, 220);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(135, 45);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // ckbConge
            // 
            this.ckbConge.AutoSize = true;
            this.ckbConge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbConge.Location = new System.Drawing.Point(26, 239);
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
            this.btnConfirmerMaj.Location = new System.Drawing.Point(600, 220);
            this.btnConfirmerMaj.Name = "btnConfirmerMaj";
            this.btnConfirmerMaj.Size = new System.Drawing.Size(135, 45);
            this.btnConfirmerMaj.TabIndex = 4;
            this.btnConfirmerMaj.Text = "Mettre à jour";
            this.btnConfirmerMaj.UseVisualStyleBackColor = true;
            this.btnConfirmerMaj.Click += new System.EventHandler(this.btnConfirmerMaj_Click);
            // 
            // lstAnciennesCasernes
            // 
            this.lstAnciennesCasernes.HideSelection = false;
            this.lstAnciennesCasernes.Location = new System.Drawing.Point(20, 105);
            this.lstAnciennesCasernes.Name = "lstAnciennesCasernes";
            this.lstAnciennesCasernes.Size = new System.Drawing.Size(360, 120);
            this.lstAnciennesCasernes.TabIndex = 3;
            this.lstAnciennesCasernes.UseCompatibleStateImageBehavior = false;
            this.lstAnciennesCasernes.View = System.Windows.Forms.View.List;
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(430, 40);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(98, 17);
            this.lblHabilitations.TabIndex = 2;
            this.lblHabilitations.Text = "Habilitations : ";
            // 
            // cboChoixCaserne
            // 
            this.cboChoixCaserne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChoixCaserne.FormattingEnabled = true;
            this.cboChoixCaserne.Location = new System.Drawing.Point(185, 42);
            this.cboChoixCaserne.Name = "cboChoixCaserne";
            this.cboChoixCaserne.Size = new System.Drawing.Size(195, 24);
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
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.pnlGestion);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'acceuil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.pnlGestion.ResumeLayout(false);
            this.pnlInfosPompiers.ResumeLayout(false);
            this.pnlInfosPompiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.grpInfosPompier.ResumeLayout(false);
            this.grpInfosCarriere.ResumeLayout(false);
            this.grpInfosCarriere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestion;
        private System.Windows.Forms.Panel pnlInfosPompiers;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.ComboBox cboCasernes;
        private System.Windows.Forms.ComboBox cboPompiers;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.Label lblNouveauPompier;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Button btnAnnuler;
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
        public System.Windows.Forms.Button btnPlusInfos;
        protected System.Windows.Forms.GroupBox grpInfosCarriere;
        public System.Windows.Forms.GroupBox grpInfosPerso;
        public System.Windows.Forms.GroupBox grpInfosPompier;
        private System.Windows.Forms.Label lblPlusPompier;
    }
}

