namespace ExtinctHeureUC
{
    partial class Stats
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
            this.lblColonneGauche = new System.Windows.Forms.Label();
            this.lblColonneDroite = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblColonneGauche
            // 
            this.lblColonneGauche.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonneGauche.Location = new System.Drawing.Point(0, 0);
            this.lblColonneGauche.Name = "lblColonneGauche";
            this.lblColonneGauche.Size = new System.Drawing.Size(177, 18);
            this.lblColonneGauche.TabIndex = 0;
            this.lblColonneGauche.Text = "Colonne gauche";
            this.lblColonneGauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColonneDroite
            // 
            this.lblColonneDroite.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonneDroite.Location = new System.Drawing.Point(178, 0);
            this.lblColonneDroite.Name = "lblColonneDroite";
            this.lblColonneDroite.Size = new System.Drawing.Size(177, 18);
            this.lblColonneDroite.TabIndex = 0;
            this.lblColonneDroite.Text = "Colonne droite";
            this.lblColonneDroite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStats
            // 
            this.pnlStats.AutoScroll = true;
            this.pnlStats.Location = new System.Drawing.Point(0, 20);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(371, 199);
            this.pnlStats.TabIndex = 1;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.lblColonneDroite);
            this.Controls.Add(this.lblColonneGauche);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(371, 219);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColonneGauche;
        private System.Windows.Forms.Label lblColonneDroite;
        private System.Windows.Forms.Panel pnlStats;
    }
}
