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
            this.grpChoix = new System.Windows.Forms.GroupBox();
            this.lblRetour = new System.Windows.Forms.Label();
            this.pcbIconeRetour = new System.Windows.Forms.PictureBox();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.pcbIconeNouveau = new System.Windows.Forms.PictureBox();
            this.cboPompiers = new System.Windows.Forms.ComboBox();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.grpGestion.SuspendLayout();
            this.grpInfosPompier.SuspendLayout();
            this.grpChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGestion
            // 
            this.grpGestion.BackColor = System.Drawing.Color.Transparent;
            this.grpGestion.Controls.Add(this.grpInfosPompier);
            this.grpGestion.Controls.Add(this.grpChoix);
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
            this.btnPlusInfos.Location = new System.Drawing.Point(587, 420);
            this.btnPlusInfos.Name = "btnPlusInfos";
            this.btnPlusInfos.Size = new System.Drawing.Size(171, 27);
            this.btnPlusInfos.TabIndex = 4;
            this.btnPlusInfos.Text = "Plus d\'informations";
            this.btnPlusInfos.UseVisualStyleBackColor = true;
            this.btnPlusInfos.Click += new System.EventHandler(this.btnPlusInfos_Click);
            // 
            // grpInfosCarriere
            // 
            this.grpInfosCarriere.Location = new System.Drawing.Point(23, 438);
            this.grpInfosCarriere.Name = "grpInfosCarriere";
            this.grpInfosCarriere.Size = new System.Drawing.Size(741, 247);
            this.grpInfosCarriere.TabIndex = 3;
            this.grpInfosCarriere.TabStop = false;
            this.grpInfosCarriere.Text = "Informations carrière";
            this.grpInfosCarriere.Visible = false;
            // 
            // grpInfosPerso
            // 
            this.grpInfosPerso.Location = new System.Drawing.Point(23, 14);
            this.grpInfosPerso.Name = "grpInfosPerso";
            this.grpInfosPerso.Size = new System.Drawing.Size(741, 407);
            this.grpInfosPerso.TabIndex = 2;
            this.grpInfosPerso.TabStop = false;
            // 
            // grpChoix
            // 
            this.grpChoix.BackColor = System.Drawing.Color.DarkRed;
            this.grpChoix.Controls.Add(this.lblRetour);
            this.grpChoix.Controls.Add(this.pcbIconeRetour);
            this.grpChoix.Controls.Add(this.lblNouveau);
            this.grpChoix.Controls.Add(this.pcbIconeNouveau);
            this.grpChoix.Controls.Add(this.cboPompiers);
            this.grpChoix.Controls.Add(this.cboCasernes);
            this.grpChoix.Controls.Add(this.lblPompier);
            this.grpChoix.Controls.Add(this.lblCaserne);
            this.grpChoix.Controls.Add(this.pcbIcone);
            this.grpChoix.Location = new System.Drawing.Point(28, 29);
            this.grpChoix.Margin = new System.Windows.Forms.Padding(4);
            this.grpChoix.Name = "grpChoix";
            this.grpChoix.Padding = new System.Windows.Forms.Padding(4);
            this.grpChoix.Size = new System.Drawing.Size(270, 623);
            this.grpChoix.TabIndex = 0;
            this.grpChoix.TabStop = false;
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRetour.Location = new System.Drawing.Point(87, 551);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(71, 21);
            this.lblRetour.TabIndex = 1;
            this.lblRetour.Text = "Annuler";
            // 
            // pcbIconeRetour
            // 
            this.pcbIconeRetour.Image = ((System.Drawing.Image)(resources.GetObject("pcbIconeRetour.Image")));
            this.pcbIconeRetour.Location = new System.Drawing.Point(11, 536);
            this.pcbIconeRetour.Name = "pcbIconeRetour";
            this.pcbIconeRetour.Size = new System.Drawing.Size(50, 50);
            this.pcbIconeRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIconeRetour.TabIndex = 5;
            this.pcbIconeRetour.TabStop = false;
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNouveau.Location = new System.Drawing.Point(87, 419);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(153, 21);
            this.lblNouveau.TabIndex = 1;
            this.lblNouveau.Text = "Nouveau Pompier";
            // 
            // pcbIconeNouveau
            // 
            this.pcbIconeNouveau.Image = ((System.Drawing.Image)(resources.GetObject("pcbIconeNouveau.Image")));
            this.pcbIconeNouveau.Location = new System.Drawing.Point(11, 391);
            this.pcbIconeNouveau.Name = "pcbIconeNouveau";
            this.pcbIconeNouveau.Size = new System.Drawing.Size(70, 70);
            this.pcbIconeNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIconeNouveau.TabIndex = 4;
            this.pcbIconeNouveau.TabStop = false;
            // 
            // cboPompiers
            // 
            this.cboPompiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPompiers.FormattingEnabled = true;
            this.cboPompiers.Location = new System.Drawing.Point(11, 255);
            this.cboPompiers.Name = "cboPompiers";
            this.cboPompiers.Size = new System.Drawing.Size(237, 29);
            this.cboPompiers.TabIndex = 3;
            this.cboPompiers.Visible = false;
            this.cboPompiers.SelectedValueChanged += new System.EventHandler(this.cboPompiers_SelectedValueChanged);
            // 
            // cboCasernes
            // 
            this.cboCasernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(11, 165);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(237, 29);
            this.cboCasernes.TabIndex = 1;
            this.cboCasernes.SelectedValueChanged += new System.EventHandler(this.cboCasernes_SelectedValueChanged);
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPompier.Location = new System.Drawing.Point(7, 216);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(231, 21);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Veuillez choisir un pompier :";
            this.lblPompier.Visible = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaserne.Location = new System.Drawing.Point(7, 125);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(241, 21);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Veuillez choisir une caserne :";
            // 
            // pcbIcone
            // 
            this.pcbIcone.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcone.Image")));
            this.pcbIcone.Location = new System.Drawing.Point(91, 28);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(65, 65);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcone.TabIndex = 1;
            this.pcbIcone.TabStop = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 853);
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
            this.grpChoix.ResumeLayout(false);
            this.grpChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconeNouveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.GroupBox grpChoix;
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
        private System.Windows.Forms.Label lblNouveau;
    }
}

