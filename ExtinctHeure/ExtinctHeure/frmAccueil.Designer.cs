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
            this.grpInfosPompier = new System.Windows.Forms.GroupBox();
            this.btnPlusInfos = new System.Windows.Forms.Button();
            this.grpInfosCarriere = new System.Windows.Forms.GroupBox();
            this.grpInfosPerso = new System.Windows.Forms.GroupBox();
            this.lblRetour = new System.Windows.Forms.Label();
            this.pcbIconeRetour = new System.Windows.Forms.PictureBox();
            this.lblNouveauPompier = new System.Windows.Forms.Label();
            this.pcbIconeNouveau = new System.Windows.Forms.PictureBox();
            this.cboPompiers = new System.Windows.Forms.ComboBox();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.pnlInfosPompiers = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpGestion.SuspendLayout();
            this.grpInfosPompier.SuspendLayout();
            this.grpInfosPerso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.pnlInfosPompiers.SuspendLayout();
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
            this.btnPlusInfos.Location = new System.Drawing.Point(618, 420);
            this.btnPlusInfos.Name = "btnPlusInfos";
            this.btnPlusInfos.Size = new System.Drawing.Size(140, 25);
            this.btnPlusInfos.TabIndex = 4;
            this.btnPlusInfos.Text = "Plus d\'informations";
            this.btnPlusInfos.UseVisualStyleBackColor = true;
            this.btnPlusInfos.Click += new System.EventHandler(this.btnPlusInfos_Click);
            // 
            // grpInfosCarriere
            // 
            this.grpInfosCarriere.Location = new System.Drawing.Point(17, 438);
            this.grpInfosCarriere.Name = "grpInfosCarriere";
            this.grpInfosCarriere.Size = new System.Drawing.Size(741, 247);
            this.grpInfosCarriere.TabIndex = 3;
            this.grpInfosCarriere.TabStop = false;
            this.grpInfosCarriere.Text = "Informations carrière";
            this.grpInfosCarriere.Visible = false;
            // 
            // grpInfosPerso
            // 
            this.grpInfosPerso.Controls.Add(this.groupBox1);
            this.grpInfosPerso.Location = new System.Drawing.Point(17, 14);
            this.grpInfosPerso.Name = "grpInfosPerso";
            this.grpInfosPerso.Size = new System.Drawing.Size(740, 405);
            this.grpInfosPerso.TabIndex = 2;
            this.grpInfosPerso.TabStop = false;
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRetour.Location = new System.Drawing.Point(88, 606);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(57, 17);
            this.lblRetour.TabIndex = 1;
            this.lblRetour.Text = "Annuler";
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
            // lblNouveauPompier
            // 
            this.lblNouveauPompier.AutoSize = true;
            this.lblNouveauPompier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNouveauPompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNouveauPompier.Location = new System.Drawing.Point(87, 433);
            this.lblNouveauPompier.Name = "lblNouveauPompier";
            this.lblNouveauPompier.Size = new System.Drawing.Size(124, 17);
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
            // cboPompiers
            // 
            this.cboPompiers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPompiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPompiers.FormattingEnabled = true;
            this.cboPompiers.Location = new System.Drawing.Point(12, 241);
            this.cboPompiers.Name = "cboPompiers";
            this.cboPompiers.Size = new System.Drawing.Size(237, 24);
            this.cboPompiers.TabIndex = 3;
            this.cboPompiers.Visible = false;
            this.cboPompiers.SelectedValueChanged += new System.EventHandler(this.cboPompiers_SelectedValueChanged);
            // 
            // cboCasernes
            // 
            this.cboCasernes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCasernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(12, 151);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(237, 24);
            this.cboCasernes.TabIndex = 1;
            this.cboCasernes.SelectedValueChanged += new System.EventHandler(this.cboCasernes_SelectedValueChanged);
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPompier.Location = new System.Drawing.Point(8, 202);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(189, 17);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Veuillez choisir un pompier :";
            this.lblPompier.Visible = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaserne.Location = new System.Drawing.Point(8, 111);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(197, 17);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Veuillez choisir une caserne :";
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test carrière";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.grpInfosPompier.ResumeLayout(false);
            this.grpInfosPerso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.pnlInfosPompiers.ResumeLayout(false);
            this.pnlInfosPompiers.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

