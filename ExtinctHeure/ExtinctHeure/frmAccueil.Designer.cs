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
            this.lblEnginNbHeure = new System.Windows.Forms.Label();
            this.lblEnginNbUtilisation = new System.Windows.Forms.Label();
            this.dgvEnginPlusUtiliseHeure = new System.Windows.Forms.DataGridView();
            this.dgvEnginPlusUtilise = new System.Windows.Forms.DataGridView();
            this.cboCaserneStat = new System.Windows.Forms.ComboBox();
            this.lblTouteCaserne = new System.Windows.Forms.Label();
            this.dgvInterventionSinistre = new System.Windows.Forms.DataGridView();
            this.lblTypeSinistre = new System.Windows.Forms.Label();
            this.dgvPompierHabilitation = new System.Windows.Forms.DataGridView();
            this.lblListeHabilitation = new System.Windows.Forms.Label();
            this.cboHabilitation = new System.Windows.Forms.ComboBox();
            this.dgvHabilitationDemandee = new System.Windows.Forms.DataGridView();
            this.lblHabilitationDemandee = new System.Windows.Forms.Label();
            this.grpStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtiliseHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtilise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterventionSinistre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompierHabilitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilitationDemandee)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStat
            // 
            this.grpStat.Controls.Add(this.cboHabilitation);
            this.grpStat.Controls.Add(this.lblTouteCaserne);
            this.grpStat.Controls.Add(this.lblEnginNbHeure);
            this.grpStat.Controls.Add(this.lblListeHabilitation);
            this.grpStat.Controls.Add(this.lblHabilitationDemandee);
            this.grpStat.Controls.Add(this.lblTypeSinistre);
            this.grpStat.Controls.Add(this.lblEnginNbUtilisation);
            this.grpStat.Controls.Add(this.dgvEnginPlusUtiliseHeure);
            this.grpStat.Controls.Add(this.dgvPompierHabilitation);
            this.grpStat.Controls.Add(this.dgvHabilitationDemandee);
            this.grpStat.Controls.Add(this.dgvInterventionSinistre);
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
            // lblEnginNbHeure
            // 
            this.lblEnginNbHeure.AutoSize = true;
            this.lblEnginNbHeure.Location = new System.Drawing.Point(857, 130);
            this.lblEnginNbHeure.Name = "lblEnginNbHeure";
            this.lblEnginNbHeure.Size = new System.Drawing.Size(262, 17);
            this.lblEnginNbHeure.TabIndex = 2;
            this.lblEnginNbHeure.Text = "Nombre d\'heure d\'utilisation des engins";
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
            // dgvEnginPlusUtilise
            // 
            this.dgvEnginPlusUtilise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnginPlusUtilise.Location = new System.Drawing.Point(22, 150);
            this.dgvEnginPlusUtilise.Name = "dgvEnginPlusUtilise";
            this.dgvEnginPlusUtilise.Size = new System.Drawing.Size(398, 219);
            this.dgvEnginPlusUtilise.TabIndex = 1;
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
            // lblTouteCaserne
            // 
            this.lblTouteCaserne.AutoSize = true;
            this.lblTouteCaserne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTouteCaserne.Location = new System.Drawing.Point(515, 409);
            this.lblTouteCaserne.Name = "lblTouteCaserne";
            this.lblTouteCaserne.Size = new System.Drawing.Size(180, 22);
            this.lblTouteCaserne.TabIndex = 3;
            this.lblTouteCaserne.Text = "Toutes les casernes";
            // 
            // dgvInterventionSinistre
            // 
            this.dgvInterventionSinistre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterventionSinistre.Location = new System.Drawing.Point(22, 521);
            this.dgvInterventionSinistre.Name = "dgvInterventionSinistre";
            this.dgvInterventionSinistre.Size = new System.Drawing.Size(355, 219);
            this.dgvInterventionSinistre.TabIndex = 1;
            // 
            // lblTypeSinistre
            // 
            this.lblTypeSinistre.AutoSize = true;
            this.lblTypeSinistre.Location = new System.Drawing.Point(55, 501);
            this.lblTypeSinistre.Name = "lblTypeSinistre";
            this.lblTypeSinistre.Size = new System.Drawing.Size(284, 17);
            this.lblTypeSinistre.TabIndex = 2;
            this.lblTypeSinistre.Text = "Nombre d\'interventions par type de sinistre";
            // 
            // dgvPompierHabilitation
            // 
            this.dgvPompierHabilitation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompierHabilitation.Location = new System.Drawing.Point(832, 521);
            this.dgvPompierHabilitation.Name = "dgvPompierHabilitation";
            this.dgvPompierHabilitation.Size = new System.Drawing.Size(355, 219);
            this.dgvPompierHabilitation.TabIndex = 1;
            // 
            // lblListeHabilitation
            // 
            this.lblListeHabilitation.AutoSize = true;
            this.lblListeHabilitation.Location = new System.Drawing.Point(933, 473);
            this.lblListeHabilitation.Name = "lblListeHabilitation";
            this.lblListeHabilitation.Size = new System.Drawing.Size(168, 17);
            this.lblListeHabilitation.TabIndex = 2;
            this.lblListeHabilitation.Text = "Pompiers par habilitation";
            // 
            // cboHabilitation
            // 
            this.cboHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHabilitation.FormattingEnabled = true;
            this.cboHabilitation.Location = new System.Drawing.Point(832, 493);
            this.cboHabilitation.Name = "cboHabilitation";
            this.cboHabilitation.Size = new System.Drawing.Size(355, 25);
            this.cboHabilitation.TabIndex = 4;
            this.cboHabilitation.SelectedIndexChanged += new System.EventHandler(this.cboHabilitation_SelectedIndexChanged);
            // 
            // dgvHabilitationDemandee
            // 
            this.dgvHabilitationDemandee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabilitationDemandee.Location = new System.Drawing.Point(428, 521);
            this.dgvHabilitationDemandee.Name = "dgvHabilitationDemandee";
            this.dgvHabilitationDemandee.Size = new System.Drawing.Size(355, 219);
            this.dgvHabilitationDemandee.TabIndex = 1;
            // 
            // lblHabilitationDemandee
            // 
            this.lblHabilitationDemandee.AutoSize = true;
            this.lblHabilitationDemandee.Location = new System.Drawing.Point(498, 501);
            this.lblHabilitationDemandee.Name = "lblHabilitationDemandee";
            this.lblHabilitationDemandee.Size = new System.Drawing.Size(221, 17);
            this.lblHabilitationDemandee.TabIndex = 2;
            this.lblHabilitationDemandee.Text = "Habilitations les plus demandées";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtiliseHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginPlusUtilise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterventionSinistre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompierHabilitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilitationDemandee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStat;
        private System.Windows.Forms.ComboBox cboCaserneStat;
        private System.Windows.Forms.Label lblEnginNbUtilisation;
        private System.Windows.Forms.DataGridView dgvEnginPlusUtilise;
        private System.Windows.Forms.Label lblEnginNbHeure;
        private System.Windows.Forms.DataGridView dgvEnginPlusUtiliseHeure;
        private System.Windows.Forms.Label lblTouteCaserne;
        private System.Windows.Forms.Label lblTypeSinistre;
        private System.Windows.Forms.DataGridView dgvInterventionSinistre;
        private System.Windows.Forms.Label lblListeHabilitation;
        private System.Windows.Forms.DataGridView dgvPompierHabilitation;
        private System.Windows.Forms.ComboBox cboHabilitation;
        private System.Windows.Forms.Label lblHabilitationDemandee;
        private System.Windows.Forms.DataGridView dgvHabilitationDemandee;
    }
}

