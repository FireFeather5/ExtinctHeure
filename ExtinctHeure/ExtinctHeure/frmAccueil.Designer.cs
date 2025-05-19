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
            this.grpMissions = new System.Windows.Forms.GroupBox();
            this.mission1 = new ExtinctHeureUC.Mission();
            this.grpMissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMissions
            // 
            this.grpMissions.Controls.Add(this.mission1);
            this.grpMissions.Location = new System.Drawing.Point(12, 155);
            this.grpMissions.Name = "grpMissions";
            this.grpMissions.Size = new System.Drawing.Size(1210, 694);
            this.grpMissions.TabIndex = 0;
            this.grpMissions.TabStop = false;
            this.grpMissions.Text = "Missions";
            this.grpMissions.VisibleChanged += new System.EventHandler(this.grpMissions_VisibleChanged);
            // 
            // mission1
            // 
            this.mission1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mission1.caserne = "*";
            this.mission1.debutMission = "*";
            this.mission1.estFini = false;
            this.mission1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mission1.idMission = -1;
            this.mission1.imageMission = null;
            this.mission1.Location = new System.Drawing.Point(7, 30);
            this.mission1.Margin = new System.Windows.Forms.Padding(4);
            this.mission1.Name = "mission1";
            this.mission1.natureMission = "*";
            this.mission1.nomMission = "*";
            this.mission1.Size = new System.Drawing.Size(1198, 150);
            this.mission1.TabIndex = 0;
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
            this.Text = "Extinct\'Heure";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grpMissions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMissions;
        private ExtinctHeureUC.Mission mission1;
    }
}

