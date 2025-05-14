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
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.pnlInfosPompiers = new System.Windows.Forms.Panel();
            this.lblRetour = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.pcbIconeRetour = new System.Windows.Forms.PictureBox();
            this.cboPompiers = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.lblNouveauPompier = new System.Windows.Forms.Label();
            this.pcbIconeNouveau = new System.Windows.Forms.PictureBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.grpInfosPompier = new System.Windows.Forms.GroupBox();
            this.btnPlusInfos = new System.Windows.Forms.Button();
            this.grpInfosCarriere = new System.Windows.Forms.GroupBox();
            this.lstHabilitations = new System.Windows.Forms.ListView();
            this.btnConfirmerMaj = new System.Windows.Forms.Button();
            this.lstAnciennesCasernes = new System.Windows.Forms.ListView();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.cboChoixCaserne = new System.Windows.Forms.ComboBox();
            this.lblRattachement = new System.Windows.Forms.Label();
            this.grpInfosPerso = new System.Windows.Forms.GroupBox();
            this.lblAncienneCasernes = new System.Windows.Forms.Label();
            this.ckbConge = new System.Windows.Forms.CheckBox();
            this.grpGestion.SuspendLayout();
            this.pnlInfosPompiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).BeginInit();
            this.grpInfosPompier.SuspendLayout();
            this.grpInfosCarriere.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGestion
            // 
            this.grpGestion.BackColor = System.Drawing.Color.Transparent;
            this.grpGestion.Controls.Add(this.pnlInfosPompiers);
            this.grpGestion.Controls.Add(this.grpInfosPompier);
            this.grpGestion.Location = new System.Drawing.Point(13, 97);
            this.grpGestion.Margin = new System.Windows.Forms.Padding(4);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Padding = new System.Windows.Forms.Padding(4);
            this.grpGestion.Size = new System.Drawing.Size(1206, 743);
            this.grpGestion.TabIndex = 0;
            this.grpGestion.TabStop = false;
            // 
            // pnlInfosPompiers
            // 
            this.pnlInfosPompiers.BackColor = System.Drawing.Color.DarkRed;
            this.pnlInfosPompiers.Controls.Add(this.lblRetour);
            this.pnlInfosPompiers.Controls.Add(this.pcbIcone);
            this.pnlInfosPompiers.Controls.Add(this.cboCasernes);
            this.pnlInfosPompiers.Controls.Add(this.pcbIconeRetour);
            this.pnlInfosPompiers.Controls.Add(this.cboPompiers);
            this.pnlInfosPompiers.Controls.Add(this.lblPompier);
            this.pnlInfosPompiers.Controls.Add(this.lblNouveauPompier);
            this.pnlInfosPompiers.Controls.Add(this.pcbIconeNouveau);
            this.pnlInfosPompiers.Controls.Add(this.lblCaserne);
            this.pnlInfosPompiers.Location = new System.Drawing.Point(37, 36);
            this.pnlInfosPompiers.Name = "pnlInfosPompiers";
            this.pnlInfosPompiers.Size = new System.Drawing.Size(270, 677);
            this.pnlInfosPompiers.TabIndex = 2;
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRetour.Location = new System.Drawing.Point(88, 606);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(71, 21);
            this.lblRetour.TabIndex = 1;
            this.lblRetour.Text = "Annuler";
            // 
            // pcbIcone
            // 
            this.pcbIcone.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcone.Image")));
            this.pcbIcone.Location = new System.Drawing.Point(92, 14);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(65, 65);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcone.TabIndex = 1;
            this.pcbIcone.TabStop = false;
            // 
            // cboCasernes
            // 
            this.cboCasernes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCasernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(12, 151);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(237, 29);
            this.cboCasernes.TabIndex = 1;
            this.cboCasernes.SelectedValueChanged += new System.EventHandler(this.cboCasernes_SelectedValueChanged);
            // 
            // pcbIconeRetour
            // 
            this.pcbIconeRetour.Image = ((System.Drawing.Image)(resources.GetObject("pcbIconeRetour.Image")));
            this.pcbIconeRetour.Location = new System.Drawing.Point(12, 591);
            this.pcbIconeRetour.Name = "pcbIconeRetour";
            this.pcbIconeRetour.Size = new System.Drawing.Size(50, 50);
            this.pcbIconeRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIconeRetour.TabIndex = 5;
            this.pcbIconeRetour.TabStop = false;
            // 
            // cboPompiers
            // 
            this.cboPompiers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPompiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPompiers.FormattingEnabled = true;
            this.cboPompiers.Location = new System.Drawing.Point(12, 241);
            this.cboPompiers.Name = "cboPompiers";
            this.cboPompiers.Size = new System.Drawing.Size(237, 29);
            this.cboPompiers.TabIndex = 3;
            this.cboPompiers.Visible = false;
            this.cboPompiers.SelectedValueChanged += new System.EventHandler(this.cboPompiers_SelectedValueChanged);
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPompier.Location = new System.Drawing.Point(8, 202);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(231, 21);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Veuillez choisir un pompier :";
            this.lblPompier.Visible = false;
            // 
            // lblNouveauPompier
            // 
            this.lblNouveauPompier.AutoSize = true;
            this.lblNouveauPompier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNouveauPompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNouveauPompier.Location = new System.Drawing.Point(87, 433);
            this.lblNouveauPompier.Name = "lblNouveauPompier";
            this.lblNouveauPompier.Size = new System.Drawing.Size(153, 21);
            this.lblNouveauPompier.TabIndex = 1;
            this.lblNouveauPompier.Text = "Nouveau Pompier";
            this.lblNouveauPompier.Click += new System.EventHandler(this.pcbIconeNouveau_Click);
            // 
            // pcbIconeNouveau
            // 
            this.pcbIconeNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbIconeNouveau.Image = ((System.Drawing.Image)(resources.GetObject("pcbIconeNouveau.Image")));
            this.pcbIconeNouveau.Location = new System.Drawing.Point(11, 405);
            this.pcbIconeNouveau.Name = "pcbIconeNouveau";
            this.pcbIconeNouveau.Size = new System.Drawing.Size(70, 70);
            this.pcbIconeNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIconeNouveau.TabIndex = 4;
            this.pcbIconeNouveau.TabStop = false;
            this.pcbIconeNouveau.Click += new System.EventHandler(this.pcbIconeNouveau_Click);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaserne.Location = new System.Drawing.Point(8, 111);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(241, 21);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Veuillez choisir une caserne :";
            // 
            // grpInfosPompier
            // 
            this.grpInfosPompier.Controls.Add(this.btnPlusInfos);
            this.grpInfosPompier.Controls.Add(this.grpInfosCarriere);
            this.grpInfosPompier.Controls.Add(this.grpInfosPerso);
            this.grpInfosPompier.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpInfosPompier.Location = new System.Drawing.Point(398, 28);
            this.grpInfosPompier.Name = "grpInfosPompier";
            this.grpInfosPompier.Size = new System.Drawing.Size(770, 700);
            this.grpInfosPompier.TabIndex = 1;
            this.grpInfosPompier.TabStop = false;
            this.grpInfosPompier.Visible = false;
            // 
            // btnPlusInfos
            // 
            this.btnPlusInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlusInfos.Location = new System.Drawing.Point(617, 395);
            this.btnPlusInfos.Name = "btnPlusInfos";
            this.btnPlusInfos.Size = new System.Drawing.Size(140, 25);
            this.btnPlusInfos.TabIndex = 4;
            this.btnPlusInfos.Text = "Plus d\'informations";
            this.btnPlusInfos.UseVisualStyleBackColor = true;
            this.btnPlusInfos.Click += new System.EventHandler(this.btnPlusInfos_Click);
            // 
            // grpInfosCarriere
            // 
            this.grpInfosCarriere.Controls.Add(this.ckbConge);
            this.grpInfosCarriere.Controls.Add(this.lblAncienneCasernes);
            this.grpInfosCarriere.Controls.Add(this.lstHabilitations);
            this.grpInfosCarriere.Controls.Add(this.btnConfirmerMaj);
            this.grpInfosCarriere.Controls.Add(this.lstAnciennesCasernes);
            this.grpInfosCarriere.Controls.Add(this.lblHabilitations);
            this.grpInfosCarriere.Controls.Add(this.cboChoixCaserne);
            this.grpInfosCarriere.Controls.Add(this.lblRattachement);
            this.grpInfosCarriere.Location = new System.Drawing.Point(17, 413);
            this.grpInfosCarriere.Name = "grpInfosCarriere";
            this.grpInfosCarriere.Size = new System.Drawing.Size(741, 281);
            this.grpInfosCarriere.TabIndex = 3;
            this.grpInfosCarriere.TabStop = false;
            this.grpInfosCarriere.Text = "Informations supplémentaire sur la carrière";
            this.grpInfosCarriere.Visible = false;
            // 
            // lstHabilitations
            // 
            this.lstHabilitations.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHabilitations.HideSelection = false;
            this.lstHabilitations.Location = new System.Drawing.Point(432, 65);
            this.lstHabilitations.Name = "lstHabilitations";
            this.lstHabilitations.Size = new System.Drawing.Size(303, 157);
            this.lstHabilitations.TabIndex = 5;
            this.lstHabilitations.UseCompatibleStateImageBehavior = false;
            this.lstHabilitations.View = System.Windows.Forms.View.List;
            // 
            // btnConfirmerMaj
            // 
            this.btnConfirmerMaj.Location = new System.Drawing.Point(601, 229);
            this.btnConfirmerMaj.Name = "btnConfirmerMaj";
            this.btnConfirmerMaj.Size = new System.Drawing.Size(134, 43);
            this.btnConfirmerMaj.TabIndex = 4;
            this.btnConfirmerMaj.Text = "Mettre à jour";
            this.btnConfirmerMaj.UseVisualStyleBackColor = true;
            // 
            // lstAnciennesCasernes
            // 
            this.lstAnciennesCasernes.HideSelection = false;
            this.lstAnciennesCasernes.Location = new System.Drawing.Point(26, 103);
            this.lstAnciennesCasernes.Name = "lstAnciennesCasernes";
            this.lstAnciennesCasernes.Size = new System.Drawing.Size(335, 119);
            this.lstAnciennesCasernes.TabIndex = 3;
            this.lstAnciennesCasernes.UseCompatibleStateImageBehavior = false;
            this.lstAnciennesCasernes.View = System.Windows.Forms.View.List;
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(428, 41);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(123, 21);
            this.lblHabilitations.TabIndex = 2;
            this.lblHabilitations.Text = "Habilitations : ";
            // 
            // cboChoixCaserne
            // 
            this.cboChoixCaserne.FormattingEnabled = true;
            this.cboChoixCaserne.Location = new System.Drawing.Point(228, 41);
            this.cboChoixCaserne.Name = "cboChoixCaserne";
            this.cboChoixCaserne.Size = new System.Drawing.Size(173, 29);
            this.cboChoixCaserne.TabIndex = 1;
            // 
            // lblRattachement
            // 
            this.lblRattachement.AutoSize = true;
            this.lblRattachement.Location = new System.Drawing.Point(22, 44);
            this.lblRattachement.Name = "lblRattachement";
            this.lblRattachement.Size = new System.Drawing.Size(200, 21);
            this.lblRattachement.TabIndex = 0;
            this.lblRattachement.Text = "Rattaché à la caserne : ";
            // 
            // grpInfosPerso
            // 
            this.grpInfosPerso.Location = new System.Drawing.Point(17, 14);
            this.grpInfosPerso.Name = "grpInfosPerso";
            this.grpInfosPerso.Size = new System.Drawing.Size(740, 375);
            this.grpInfosPerso.TabIndex = 2;
            this.grpInfosPerso.TabStop = false;
            // 
            // lblAncienneCasernes
            // 
            this.lblAncienneCasernes.AutoSize = true;
            this.lblAncienneCasernes.Location = new System.Drawing.Point(22, 76);
            this.lblAncienneCasernes.Name = "lblAncienneCasernes";
            this.lblAncienneCasernes.Size = new System.Drawing.Size(205, 21);
            this.lblAncienneCasernes.TabIndex = 6;
            this.lblAncienneCasernes.Text = "Anciennes affectations : ";
            // 
            // ckbConge
            // 
            this.ckbConge.AutoSize = true;
            this.ckbConge.Location = new System.Drawing.Point(26, 239);
            this.ckbConge.Name = "ckbConge";
            this.ckbConge.Size = new System.Drawing.Size(108, 25);
            this.ckbConge.TabIndex = 7;
            this.ckbConge.Text = "En congé";
            this.ckbConge.UseVisualStyleBackColor = true;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.grpGestion);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'acceuil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grpGestion.ResumeLayout(false);
            this.pnlInfosPompiers.ResumeLayout(false);
            this.pnlInfosPompiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).EndInit();
            this.grpInfosPompier.ResumeLayout(false);
            this.grpInfosCarriere.ResumeLayout(false);
            this.grpInfosCarriere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.ComboBox cboPompiers;
        private System.Windows.Forms.ComboBox cboCasernes;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.PictureBox pcbIconeNouveau;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.PictureBox pcbIconeRetour;
        private System.Windows.Forms.GroupBox grpInfosPompier;
        private System.Windows.Forms.GroupBox grpInfosCarriere;
        private System.Windows.Forms.GroupBox grpInfosPerso;
        private System.Windows.Forms.Button btnPlusInfos;
        private System.Windows.Forms.Label lblNouveauPompier;
        private System.Windows.Forms.Panel pnlInfosPompiers;
        private System.Windows.Forms.ComboBox cboChoixCaserne;
        private System.Windows.Forms.Label lblRattachement;
        private System.Windows.Forms.ListView lstAnciennesCasernes;
        private System.Windows.Forms.Label lblHabilitations;
        private System.Windows.Forms.ListView lstHabilitations;
        private System.Windows.Forms.Button btnConfirmerMaj;
        private System.Windows.Forms.Label lblAncienneCasernes;
        private System.Windows.Forms.CheckBox ckbConge;
    }
}

