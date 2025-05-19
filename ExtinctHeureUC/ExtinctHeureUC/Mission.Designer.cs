namespace ExtinctHeureUC
{
    partial class Mission
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCloture = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.pcbImageMission = new System.Windows.Forms.PictureBox();
            this.lblTextId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTextDebut = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblTextCaserne = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNatureMission = new System.Windows.Forms.Label();
            this.lblTextNomMission = new System.Windows.Forms.Label();
            this.lblNomMission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageMission)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloture
            // 
            this.btnCloture.Location = new System.Drawing.Point(966, 25);
            this.btnCloture.Name = "btnCloture";
            this.btnCloture.Size = new System.Drawing.Size(100, 100);
            this.btnCloture.TabIndex = 0;
            this.btnCloture.Text = "Cloture";
            this.btnCloture.UseVisualStyleBackColor = true;
            this.btnCloture.Click += new System.EventHandler(this.btnCloture_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.Location = new System.Drawing.Point(1072, 25);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(100, 100);
            this.btnRapport.TabIndex = 0;
            this.btnRapport.Text = "Rapport";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // pcbImageMission
            // 
            this.pcbImageMission.Location = new System.Drawing.Point(3, 3);
            this.pcbImageMission.Name = "pcbImageMission";
            this.pcbImageMission.Size = new System.Drawing.Size(144, 144);
            this.pcbImageMission.TabIndex = 1;
            this.pcbImageMission.TabStop = false;
            // 
            // lblTextId
            // 
            this.lblTextId.AutoSize = true;
            this.lblTextId.Location = new System.Drawing.Point(255, 14);
            this.lblTextId.Name = "lblTextId";
            this.lblTextId.Size = new System.Drawing.Size(120, 17);
            this.lblTextId.TabIndex = 2;
            this.lblTextId.Text = "ID de la mission :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(381, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "-1";
            // 
            // lblTextDebut
            // 
            this.lblTextDebut.AutoSize = true;
            this.lblTextDebut.Location = new System.Drawing.Point(484, 14);
            this.lblTextDebut.Name = "lblTextDebut";
            this.lblTextDebut.Size = new System.Drawing.Size(107, 17);
            this.lblTextDebut.TabIndex = 2;
            this.lblTextDebut.Text = "Date de début :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(597, 14);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(14, 17);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "*";
            // 
            // lblTextCaserne
            // 
            this.lblTextCaserne.AutoSize = true;
            this.lblTextCaserne.Location = new System.Drawing.Point(731, 14);
            this.lblTextCaserne.Name = "lblTextCaserne";
            this.lblTextCaserne.Size = new System.Drawing.Size(72, 17);
            this.lblTextCaserne.TabIndex = 2;
            this.lblTextCaserne.Text = "Caserne :";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(809, 14);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(14, 17);
            this.lblCaserne.TabIndex = 2;
            this.lblCaserne.Text = "*";
            // 
            // lblNatureMission
            // 
            this.lblNatureMission.AutoSize = true;
            this.lblNatureMission.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatureMission.Location = new System.Drawing.Point(255, 67);
            this.lblNatureMission.Name = "lblNatureMission";
            this.lblNatureMission.Size = new System.Drawing.Size(14, 18);
            this.lblNatureMission.TabIndex = 3;
            this.lblNatureMission.Text = "*";
            // 
            // lblTextNomMission
            // 
            this.lblTextNomMission.AutoSize = true;
            this.lblTextNomMission.Location = new System.Drawing.Point(556, 67);
            this.lblTextNomMission.Name = "lblTextNomMission";
            this.lblTextNomMission.Size = new System.Drawing.Size(35, 17);
            this.lblTextNomMission.TabIndex = 4;
            this.lblTextNomMission.Text = ">>>";
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Location = new System.Drawing.Point(597, 67);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(14, 17);
            this.lblNomMission.TabIndex = 4;
            this.lblNomMission.Text = "*";
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.lblTextNomMission);
            this.Controls.Add(this.lblNatureMission);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTextCaserne);
            this.Controls.Add(this.lblTextDebut);
            this.Controls.Add(this.lblTextId);
            this.Controls.Add(this.pcbImageMission);
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.btnCloture);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(1196, 148);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageMission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloture;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.PictureBox pcbImageMission;
        private System.Windows.Forms.Label lblTextId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTextDebut;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblTextCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNatureMission;
        private System.Windows.Forms.Label lblTextNomMission;
        private System.Windows.Forms.Label lblNomMission;
    }
}
