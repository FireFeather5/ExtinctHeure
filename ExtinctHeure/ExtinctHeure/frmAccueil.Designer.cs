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
            this.grpStat = new System.Windows.Forms.GroupBox();
            this.cboCaserneStat = new System.Windows.Forms.ComboBox();
            this.dgvEnginPlusUtilise = new System.Windows.Forms.DataGridView();
            this.lblEnginNbUtilisation = new System.Windows.Forms.Label();
            this.dgvEnginPlusUtiliseHeure = new System.Windows.Forms.DataGridView();
            this.lblEnginNbHeure = new System.Windows.Forms.Label();
            this.grpStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtilise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtiliseHeure)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStat
            // 
            this.grpStat.Controls.Add(this.lblEnginNbHeure);
            this.grpStat.Controls.Add(this.lblEnginNbUtilisation);
            this.grpStat.Controls.Add(this.dgvEnginPlusUtiliseHeure);
            this.grpStat.Controls.Add(this.dgvEnginPlusUtilise);
            this.grpStat.Controls.Add(this.cboCaserneStat);
            this.grpStat.Location = new System.Drawing.Point(12, 103);
            this.grpStat.Name = "grpStat";
            this.grpStat.Size = new System.Drawing.Size(1210, 746);
            this.grpStat.TabIndex = 0;
            this.grpStat.TabStop = false;
            this.grpStat.Text = "Statistiques";
            this.grpStat.VisibleChanged += new System.EventHandler(this.grpStat_VisibleChanged);
            // 
            // cboCaserneStat
            // 
            this.cboCaserneStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserneStat.FormattingEnabled = true;
            this.cboCaserneStat.Location = new System.Drawing.Point(456, 24);
            this.cboCaserneStat.Name = "cboCaserneStat";
            this.cboCaserneStat.Size = new System.Drawing.Size(239, 25);
            this.cboCaserneStat.TabIndex = 0;
            this.cboCaserneStat.SelectedIndexChanged += new System.EventHandler(this.cboCaserneStat_SelectedIndexChanged);
            // 
            // dgvEnginPlusUtilise
            // 
            this.dgvEnginPlusUtilise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnginPlusUtilise.Location = new System.Drawing.Point(22, 150);
            this.dgvEnginPlusUtilise.Name = "dgvEnginPlusUtilise";
            this.dgvEnginPlusUtilise.Size = new System.Drawing.Size(398, 219);
            this.dgvEnginPlusUtilise.TabIndex = 1;
            // 
            // lblEnginNbUtilisation
            // 
            this.lblEnginNbUtilisation.AutoSize = true;
            this.lblEnginNbUtilisation.Location = new System.Drawing.Point(112, 130);
            this.lblEnginNbUtilisation.Name = "lblEnginNbUtilisation";
            this.lblEnginNbUtilisation.Size = new System.Drawing.Size(210, 17);
            this.lblEnginNbUtilisation.TabIndex = 2;
            this.lblEnginNbUtilisation.Text = "Nombre d\'utilisation des engins";
            // 
            // dgvEnginPlusUtiliseHeure
            // 
            this.dgvEnginPlusUtiliseHeure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnginPlusUtiliseHeure.Location = new System.Drawing.Point(789, 150);
            this.dgvEnginPlusUtiliseHeure.Name = "dgvEnginPlusUtiliseHeure";
            this.dgvEnginPlusUtiliseHeure.Size = new System.Drawing.Size(398, 219);
            this.dgvEnginPlusUtiliseHeure.TabIndex = 1;
            // 
            // lblEnginNbHeure
            // 
            this.lblEnginNbHeure.AutoSize = true;
            this.lblEnginNbHeure.Location = new System.Drawing.Point(857, 130);
            this.lblEnginNbHeure.Name = "lblEnginNbHeure";
            this.lblEnginNbHeure.Size = new System.Drawing.Size(262, 17);
            this.lblEnginNbHeure.TabIndex = 2;
            this.lblEnginNbHeure.Text = "Nombre d\'heure d\'utilisation des engins";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.grpStat);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extinct\'Heure";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grpStat.ResumeLayout(false);
            this.grpStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtilise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtiliseHeure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStat;
        private System.Windows.Forms.ComboBox cboCaserneStat;
        private System.Windows.Forms.Label lblEnginNbUtilisation;
        private System.Windows.Forms.DataGridView dgvEnginPlusUtilise;
        private System.Windows.Forms.Label lblEnginNbHeure;
        private System.Windows.Forms.DataGridView dgvEnginPlusUtiliseHeure;
    }
}

