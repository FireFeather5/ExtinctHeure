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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboPompiers = new System.Windows.Forms.ComboBox();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.grpGestion.SuspendLayout();
            this.grpInfosPompier.SuspendLayout();
            this.grpChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.grpInfosPompier);
            this.grpGestion.Controls.Add(this.grpChoix);
            this.grpGestion.Location = new System.Drawing.Point(110, 117);
            this.grpGestion.Margin = new System.Windows.Forms.Padding(4);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Padding = new System.Windows.Forms.Padding(4);
            this.grpGestion.Size = new System.Drawing.Size(1301, 743);
            this.grpGestion.TabIndex = 0;
            this.grpGestion.TabStop = false;
            // 
            // grpInfosPompier
            // 
            this.grpInfosPompier.Controls.Add(this.btnPlusInfos);
            this.grpInfosPompier.Controls.Add(this.grpInfosCarriere);
            this.grpInfosPompier.Controls.Add(this.grpInfosPerso);
            this.grpInfosPompier.Location = new System.Drawing.Point(446, 35);
            this.grpInfosPompier.Name = "grpInfosPompier";
            this.grpInfosPompier.Size = new System.Drawing.Size(759, 701);
            this.grpInfosPompier.TabIndex = 1;
            this.grpInfosPompier.TabStop = false;
            // 
            // btnPlusInfos
            // 
            this.btnPlusInfos.Location = new System.Drawing.Point(536, 417);
            this.btnPlusInfos.Name = "btnPlusInfos";
            this.btnPlusInfos.Size = new System.Drawing.Size(197, 30);
            this.btnPlusInfos.TabIndex = 4;
            this.btnPlusInfos.Text = "Plus d\'informations";
            this.btnPlusInfos.UseVisualStyleBackColor = true;
            this.btnPlusInfos.Click += new System.EventHandler(this.btnPlusInfos_Click);
            // 
            // grpInfosCarriere
            // 
            this.grpInfosCarriere.Location = new System.Drawing.Point(23, 438);
            this.grpInfosCarriere.Name = "grpInfosCarriere";
            this.grpInfosCarriere.Size = new System.Drawing.Size(710, 257);
            this.grpInfosCarriere.TabIndex = 3;
            this.grpInfosCarriere.TabStop = false;
            this.grpInfosCarriere.Visible = false;
            // 
            // grpInfosPerso
            // 
            this.grpInfosPerso.Location = new System.Drawing.Point(23, 14);
            this.grpInfosPerso.Name = "grpInfosPerso";
            this.grpInfosPerso.Size = new System.Drawing.Size(710, 407);
            this.grpInfosPerso.TabIndex = 2;
            this.grpInfosPerso.TabStop = false;
            // 
            // grpChoix
            // 
            this.grpChoix.Controls.Add(this.lblRetour);
            this.grpChoix.Controls.Add(this.pictureBox2);
            this.grpChoix.Controls.Add(this.lblNouveau);
            this.grpChoix.Controls.Add(this.pictureBox1);
            this.grpChoix.Controls.Add(this.cboPompiers);
            this.grpChoix.Controls.Add(this.cboCasernes);
            this.grpChoix.Controls.Add(this.lblPompier);
            this.grpChoix.Controls.Add(this.lblCaserne);
            this.grpChoix.Controls.Add(this.pcbIcone);
            this.grpChoix.Location = new System.Drawing.Point(28, 29);
            this.grpChoix.Margin = new System.Windows.Forms.Padding(4);
            this.grpChoix.Name = "grpChoix";
            this.grpChoix.Padding = new System.Windows.Forms.Padding(4);
            this.grpChoix.Size = new System.Drawing.Size(270, 688);
            this.grpChoix.TabIndex = 0;
            this.grpChoix.TabStop = false;
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.Location = new System.Drawing.Point(74, 613);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(64, 21);
            this.lblRetour.TabIndex = 1;
            this.lblRetour.Text = "Retour";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 598);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Location = new System.Drawing.Point(74, 406);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(82, 21);
            this.lblNouveau.TabIndex = 1;
            this.lblNouveau.Text = "Nouveau";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cboPompiers
            // 
            this.cboPompiers.FormattingEnabled = true;
            this.cboPompiers.Location = new System.Drawing.Point(11, 255);
            this.cboPompiers.Name = "cboPompiers";
            this.cboPompiers.Size = new System.Drawing.Size(237, 29);
            this.cboPompiers.TabIndex = 3;
            this.cboPompiers.SelectedValueChanged += new System.EventHandler(this.cboPompiers_SelectedValueChanged);
            // 
            // cboCasernes
            // 
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(11, 165);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(237, 29);
            this.cboCasernes.TabIndex = 1;
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.Location = new System.Drawing.Point(7, 216);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(231, 21);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Veuillez choisir un pompier :";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
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
            this.ClientSize = new System.Drawing.Size(1443, 873);
            this.Controls.Add(this.grpGestion);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'acceuil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grpGestion.ResumeLayout(false);
            this.grpInfosPompier.ResumeLayout(false);
            this.grpChoix.ResumeLayout(false);
            this.grpChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpInfosPompier;
        private System.Windows.Forms.GroupBox grpInfosCarriere;
        private System.Windows.Forms.GroupBox grpInfosPerso;
        private System.Windows.Forms.Button btnPlusInfos;
    }
}

