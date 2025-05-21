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
            this.pnlMissions = new System.Windows.Forms.Panel();
            this.grpMissions = new System.Windows.Forms.GroupBox();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.grpMissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMissions
            // 
            this.pnlMissions.AutoScroll = true;
            this.pnlMissions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMissions.Location = new System.Drawing.Point(3, 90);
            this.pnlMissions.Name = "pnlMissions";
            this.pnlMissions.Size = new System.Drawing.Size(1204, 601);
            this.pnlMissions.TabIndex = 1;
            // 
            // grpMissions
            // 
            this.grpMissions.Controls.Add(this.chkEnCours);
            this.grpMissions.Controls.Add(this.pnlMissions);
            this.grpMissions.Location = new System.Drawing.Point(12, 155);
            this.grpMissions.Name = "grpMissions";
            this.grpMissions.Size = new System.Drawing.Size(1210, 694);
            this.grpMissions.TabIndex = 0;
            this.grpMissions.TabStop = false;
            this.grpMissions.Text = "Missions";
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
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.grpMissions);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extinct\'Heure";
            this.grpMissions.ResumeLayout(false);
            this.grpMissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMissions;
        private System.Windows.Forms.GroupBox grpMissions;
        private System.Windows.Forms.CheckBox chkEnCours;
    }
}

