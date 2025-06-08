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
            this.statsEnginPlusUtiliseHeure = new ExtinctHeureUC.Stats();
            this.statsPompierHabilitation = new ExtinctHeureUC.Stats();
            this.statsHabilitationDemandee = new ExtinctHeureUC.Stats();
            this.statsInterventionSinistre = new ExtinctHeureUC.Stats();
            this.statsEnginPlusUtilise = new ExtinctHeureUC.Stats();
            this.cboHabilitation = new System.Windows.Forms.ComboBox();
            this.lblTouteCaserne = new System.Windows.Forms.Label();
            this.lblEnginNbHeure = new System.Windows.Forms.Label();
            this.lblListeHabilitation = new System.Windows.Forms.Label();
            this.lblHabilitationDemandee = new System.Windows.Forms.Label();
            this.lblTypeSinistre = new System.Windows.Forms.Label();
            this.lblEnginNbUtilisation = new System.Windows.Forms.Label();
            this.cboCaserneStat = new System.Windows.Forms.ComboBox();
            this.lblParCaserne = new System.Windows.Forms.Label();
            this.grpStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStat
            // 
            this.grpStat.Controls.Add(this.statsEnginPlusUtiliseHeure);
            this.grpStat.Controls.Add(this.statsPompierHabilitation);
            this.grpStat.Controls.Add(this.statsHabilitationDemandee);
            this.grpStat.Controls.Add(this.statsInterventionSinistre);
            this.grpStat.Controls.Add(this.statsEnginPlusUtilise);
            this.grpStat.Controls.Add(this.cboHabilitation);
            this.grpStat.Controls.Add(this.lblParCaserne);
            this.grpStat.Controls.Add(this.lblTouteCaserne);
            this.grpStat.Controls.Add(this.lblEnginNbHeure);
            this.grpStat.Controls.Add(this.lblListeHabilitation);
            this.grpStat.Controls.Add(this.lblHabilitationDemandee);
            this.grpStat.Controls.Add(this.lblTypeSinistre);
            this.grpStat.Controls.Add(this.lblEnginNbUtilisation);
            this.grpStat.Controls.Add(this.cboCaserneStat);
            this.grpStat.Location = new System.Drawing.Point(12, 103);
            this.grpStat.Name = "grpStat";
            this.grpStat.Size = new System.Drawing.Size(1210, 746);
            this.grpStat.TabIndex = 0;
            this.grpStat.TabStop = false;
            this.grpStat.Text = "Statistiques";
            this.grpStat.VisibleChanged += new System.EventHandler(this.grpStat_VisibleChanged);
            // 
            // statsEnginPlusUtiliseHeure
            // 
            this.statsEnginPlusUtiliseHeure.ColonneDroite = "Nombre d\'heure";
            this.statsEnginPlusUtiliseHeure.ColonneGauche = "Nom de l\'engin";
            this.statsEnginPlusUtiliseHeure.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsEnginPlusUtiliseHeure.Location = new System.Drawing.Point(832, 494);
            this.statsEnginPlusUtiliseHeure.Margin = new System.Windows.Forms.Padding(4);
            this.statsEnginPlusUtiliseHeure.Name = "statsEnginPlusUtiliseHeure";
            this.statsEnginPlusUtiliseHeure.Size = new System.Drawing.Size(371, 219);
            this.statsEnginPlusUtiliseHeure.TabIndex = 5;
            // 
            // statsPompierHabilitation
            // 
            this.statsPompierHabilitation.ColonneDroite = "Prénom";
            this.statsPompierHabilitation.ColonneGauche = "Nom";
            this.statsPompierHabilitation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsPompierHabilitation.Location = new System.Drawing.Point(832, 108);
            this.statsPompierHabilitation.Margin = new System.Windows.Forms.Padding(4);
            this.statsPompierHabilitation.Name = "statsPompierHabilitation";
            this.statsPompierHabilitation.Size = new System.Drawing.Size(371, 219);
            this.statsPompierHabilitation.TabIndex = 5;
            // 
            // statsHabilitationDemandee
            // 
            this.statsHabilitationDemandee.ColonneDroite = "Nombre de demande";
            this.statsHabilitationDemandee.ColonneGauche = "Habilitation";
            this.statsHabilitationDemandee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsHabilitationDemandee.Location = new System.Drawing.Point(428, 108);
            this.statsHabilitationDemandee.Margin = new System.Windows.Forms.Padding(4);
            this.statsHabilitationDemandee.Name = "statsHabilitationDemandee";
            this.statsHabilitationDemandee.Size = new System.Drawing.Size(371, 219);
            this.statsHabilitationDemandee.TabIndex = 5;
            // 
            // statsInterventionSinistre
            // 
            this.statsInterventionSinistre.ColonneDroite = "Nombre d\'interventions";
            this.statsInterventionSinistre.ColonneGauche = "Nature du sinistre";
            this.statsInterventionSinistre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsInterventionSinistre.Location = new System.Drawing.Point(22, 108);
            this.statsInterventionSinistre.Margin = new System.Windows.Forms.Padding(4);
            this.statsInterventionSinistre.Name = "statsInterventionSinistre";
            this.statsInterventionSinistre.Size = new System.Drawing.Size(371, 219);
            this.statsInterventionSinistre.TabIndex = 5;
            // 
            // statsEnginPlusUtilise
            // 
            this.statsEnginPlusUtilise.ColonneDroite = "Nombre d\'utilisation";
            this.statsEnginPlusUtilise.ColonneGauche = "Nom de l\'engin";
            this.statsEnginPlusUtilise.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsEnginPlusUtilise.Location = new System.Drawing.Point(22, 494);
            this.statsEnginPlusUtilise.Margin = new System.Windows.Forms.Padding(4);
            this.statsEnginPlusUtilise.Name = "statsEnginPlusUtilise";
            this.statsEnginPlusUtilise.Size = new System.Drawing.Size(371, 219);
            this.statsEnginPlusUtilise.TabIndex = 5;
            // 
            // cboHabilitation
            // 
            this.cboHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHabilitation.FormattingEnabled = true;
            this.cboHabilitation.Location = new System.Drawing.Point(832, 334);
            this.cboHabilitation.Name = "cboHabilitation";
            this.cboHabilitation.Size = new System.Drawing.Size(355, 25);
            this.cboHabilitation.TabIndex = 4;
            this.cboHabilitation.SelectedIndexChanged += new System.EventHandler(this.cboHabilitation_SelectedIndexChanged);
            // 
            // lblTouteCaserne
            // 
            this.lblTouteCaserne.AutoSize = true;
            this.lblTouteCaserne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTouteCaserne.Location = new System.Drawing.Point(515, 52);
            this.lblTouteCaserne.Name = "lblTouteCaserne";
            this.lblTouteCaserne.Size = new System.Drawing.Size(180, 22);
            this.lblTouteCaserne.TabIndex = 3;
            this.lblTouteCaserne.Text = "Toutes les casernes";
            // 
            // lblEnginNbHeure
            // 
            this.lblEnginNbHeure.AutoSize = true;
            this.lblEnginNbHeure.Location = new System.Drawing.Point(877, 473);
            this.lblEnginNbHeure.Name = "lblEnginNbHeure";
            this.lblEnginNbHeure.Size = new System.Drawing.Size(262, 17);
            this.lblEnginNbHeure.TabIndex = 2;
            this.lblEnginNbHeure.Text = "Nombre d\'heure d\'utilisation des engins";
            // 
            // lblListeHabilitation
            // 
            this.lblListeHabilitation.AutoSize = true;
            this.lblListeHabilitation.Location = new System.Drawing.Point(933, 87);
            this.lblListeHabilitation.Name = "lblListeHabilitation";
            this.lblListeHabilitation.Size = new System.Drawing.Size(168, 17);
            this.lblListeHabilitation.TabIndex = 2;
            this.lblListeHabilitation.Text = "Pompiers par habilitation";
            // 
            // lblHabilitationDemandee
            // 
            this.lblHabilitationDemandee.AutoSize = true;
            this.lblHabilitationDemandee.Location = new System.Drawing.Point(498, 88);
            this.lblHabilitationDemandee.Name = "lblHabilitationDemandee";
            this.lblHabilitationDemandee.Size = new System.Drawing.Size(221, 17);
            this.lblHabilitationDemandee.TabIndex = 2;
            this.lblHabilitationDemandee.Text = "Habilitations les plus demandées";
            // 
            // lblTypeSinistre
            // 
            this.lblTypeSinistre.AutoSize = true;
            this.lblTypeSinistre.Location = new System.Drawing.Point(55, 88);
            this.lblTypeSinistre.Name = "lblTypeSinistre";
            this.lblTypeSinistre.Size = new System.Drawing.Size(284, 17);
            this.lblTypeSinistre.TabIndex = 2;
            this.lblTypeSinistre.Text = "Nombre d\'interventions par type de sinistre";
            // 
            // lblEnginNbUtilisation
            // 
            this.lblEnginNbUtilisation.AutoSize = true;
            this.lblEnginNbUtilisation.Location = new System.Drawing.Point(90, 473);
            this.lblEnginNbUtilisation.Name = "lblEnginNbUtilisation";
            this.lblEnginNbUtilisation.Size = new System.Drawing.Size(210, 17);
            this.lblEnginNbUtilisation.TabIndex = 2;
            this.lblEnginNbUtilisation.Text = "Nombre d\'utilisation des engins";
            // 
            // cboCaserneStat
            // 
            this.cboCaserneStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserneStat.FormattingEnabled = true;
            this.cboCaserneStat.Location = new System.Drawing.Point(480, 402);
            this.cboCaserneStat.Name = "cboCaserneStat";
            this.cboCaserneStat.Size = new System.Drawing.Size(239, 25);
            this.cboCaserneStat.TabIndex = 0;
            this.cboCaserneStat.SelectedIndexChanged += new System.EventHandler(this.cboCaserneStat_SelectedIndexChanged);
            // 
            // lblParCaserne
            // 
            this.lblParCaserne.AutoSize = true;
            this.lblParCaserne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParCaserne.Location = new System.Drawing.Point(550, 377);
            this.lblParCaserne.Name = "lblParCaserne";
            this.lblParCaserne.Size = new System.Drawing.Size(112, 22);
            this.lblParCaserne.TabIndex = 3;
            this.lblParCaserne.Text = "Par caserne";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStat;
        private System.Windows.Forms.ComboBox cboCaserneStat;
        private System.Windows.Forms.Label lblEnginNbUtilisation;
        private System.Windows.Forms.Label lblEnginNbHeure;
        private System.Windows.Forms.Label lblTouteCaserne;
        private System.Windows.Forms.Label lblTypeSinistre;
        private System.Windows.Forms.Label lblListeHabilitation;
        private System.Windows.Forms.ComboBox cboHabilitation;
        private System.Windows.Forms.Label lblHabilitationDemandee;
        private ExtinctHeureUC.Stats statsEnginPlusUtiliseHeure;
        private ExtinctHeureUC.Stats statsEnginPlusUtilise;
        private ExtinctHeureUC.Stats statsInterventionSinistre;
        private ExtinctHeureUC.Stats statsHabilitationDemandee;
        private ExtinctHeureUC.Stats statsPompierHabilitation;
        private System.Windows.Forms.Label lblParCaserne;
    }
}

