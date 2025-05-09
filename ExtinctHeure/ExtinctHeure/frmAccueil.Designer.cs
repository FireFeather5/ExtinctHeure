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
            this.grpChoix = new System.Windows.Forms.GroupBox();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRetour = new System.Windows.Forms.Label();
            this.grpGestion.SuspendLayout();
            this.grpChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.grpChoix);
            this.grpGestion.Location = new System.Drawing.Point(30, 114);
            this.grpGestion.Margin = new System.Windows.Forms.Padding(4);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Padding = new System.Windows.Forms.Padding(4);
            this.grpGestion.Size = new System.Drawing.Size(920, 538);
            this.grpGestion.TabIndex = 0;
            this.grpGestion.TabStop = false;
            // 
            // grpChoix
            // 
            this.grpChoix.Controls.Add(this.lblRetour);
            this.grpChoix.Controls.Add(this.pictureBox2);
            this.grpChoix.Controls.Add(this.lblNouveau);
            this.grpChoix.Controls.Add(this.pictureBox1);
            this.grpChoix.Controls.Add(this.cboPompier);
            this.grpChoix.Controls.Add(this.cboCaserne);
            this.grpChoix.Controls.Add(this.lblPompier);
            this.grpChoix.Controls.Add(this.lblCaserne);
            this.grpChoix.Controls.Add(this.pcbIcone);
            this.grpChoix.Location = new System.Drawing.Point(28, 29);
            this.grpChoix.Margin = new System.Windows.Forms.Padding(4);
            this.grpChoix.Name = "grpChoix";
            this.grpChoix.Padding = new System.Windows.Forms.Padding(4);
            this.grpChoix.Size = new System.Drawing.Size(270, 487);
            this.grpChoix.TabIndex = 0;
            this.grpChoix.TabStop = false;
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Location = new System.Drawing.Point(74, 302);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(82, 21);
            this.lblNouveau.TabIndex = 1;
            this.lblNouveau.Text = "Nouveau";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cboPompier
            // 
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.Location = new System.Drawing.Point(11, 233);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(237, 29);
            this.cboPompier.TabIndex = 3;
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(11, 143);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(237, 29);
            this.cboCaserne.TabIndex = 1;
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.Location = new System.Drawing.Point(7, 194);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(231, 21);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Veuillez choisir un pompier :";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(7, 103);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(241, 21);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Veuillez choisir une caserne :";
            // 
            // pcbIcone
            // 
            this.pcbIcone.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcone.Image")));
            this.pcbIcone.Location = new System.Drawing.Point(106, 28);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(50, 50);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcone.TabIndex = 1;
            this.pcbIcone.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 421);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.Location = new System.Drawing.Point(74, 436);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(64, 21);
            this.lblRetour.TabIndex = 1;
            this.lblRetour.Text = "Retour";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 677);
            this.Controls.Add(this.grpGestion);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'acceuil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grpGestion.ResumeLayout(false);
            this.grpChoix.ResumeLayout(false);
            this.grpChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.GroupBox grpChoix;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

