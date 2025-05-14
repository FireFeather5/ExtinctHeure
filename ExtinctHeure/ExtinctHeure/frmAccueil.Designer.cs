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
            this.grpEngins = new System.Windows.Forms.GroupBox();
            this.chkReparation = new System.Windows.Forms.CheckBox();
            this.chkMission = new System.Windows.Forms.CheckBox();
            this.pcbEngin = new System.Windows.Forms.PictureBox();
            this.lblReparation = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblReception = new System.Windows.Forms.Label();
            this.lblReceptionEngin = new System.Windows.Forms.Label();
            this.lblNumeroEngin = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.grpEngins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEngins
            // 
            this.grpEngins.Controls.Add(this.btnLast);
            this.grpEngins.Controls.Add(this.btnNext);
            this.grpEngins.Controls.Add(this.btnPrevious);
            this.grpEngins.Controls.Add(this.btnFirst);
            this.grpEngins.Controls.Add(this.chkReparation);
            this.grpEngins.Controls.Add(this.chkMission);
            this.grpEngins.Controls.Add(this.pcbEngin);
            this.grpEngins.Controls.Add(this.lblReparation);
            this.grpEngins.Controls.Add(this.lblMission);
            this.grpEngins.Controls.Add(this.lblReception);
            this.grpEngins.Controls.Add(this.lblReceptionEngin);
            this.grpEngins.Controls.Add(this.lblNumeroEngin);
            this.grpEngins.Controls.Add(this.lblNumero);
            this.grpEngins.Controls.Add(this.cboCaserne);
            this.grpEngins.Controls.Add(this.lblCaserne);
            this.grpEngins.Location = new System.Drawing.Point(12, 100);
            this.grpEngins.Name = "grpEngins";
            this.grpEngins.Size = new System.Drawing.Size(1210, 749);
            this.grpEngins.TabIndex = 0;
            this.grpEngins.TabStop = false;
            this.grpEngins.Text = "Liste des engins";
            // 
            // chkReparation
            // 
            this.chkReparation.AutoSize = true;
            this.chkReparation.Enabled = false;
            this.chkReparation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReparation.Location = new System.Drawing.Point(433, 467);
            this.chkReparation.Name = "chkReparation";
            this.chkReparation.Size = new System.Drawing.Size(15, 14);
            this.chkReparation.TabIndex = 5;
            this.chkReparation.UseVisualStyleBackColor = true;
            // 
            // chkMission
            // 
            this.chkMission.AutoSize = true;
            this.chkMission.Enabled = false;
            this.chkMission.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMission.Location = new System.Drawing.Point(433, 434);
            this.chkMission.Name = "chkMission";
            this.chkMission.Size = new System.Drawing.Size(15, 14);
            this.chkMission.TabIndex = 5;
            this.chkMission.UseVisualStyleBackColor = true;
            // 
            // pcbEngin
            // 
            this.pcbEngin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbEngin.Location = new System.Drawing.Point(630, 119);
            this.pcbEngin.Name = "pcbEngin";
            this.pcbEngin.Size = new System.Drawing.Size(500, 500);
            this.pcbEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEngin.TabIndex = 4;
            this.pcbEngin.TabStop = false;
            // 
            // lblReparation
            // 
            this.lblReparation.AutoSize = true;
            this.lblReparation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparation.Location = new System.Drawing.Point(158, 461);
            this.lblReparation.Name = "lblReparation";
            this.lblReparation.Size = new System.Drawing.Size(148, 24);
            this.lblReparation.TabIndex = 3;
            this.lblReparation.Text = "En réparation :";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(158, 428);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(124, 24);
            this.lblMission.TabIndex = 3;
            this.lblMission.Text = "En mission :";
            // 
            // lblReception
            // 
            this.lblReception.AutoSize = true;
            this.lblReception.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReception.Location = new System.Drawing.Point(157, 324);
            this.lblReception.Name = "lblReception";
            this.lblReception.Size = new System.Drawing.Size(189, 24);
            this.lblReception.TabIndex = 3;
            this.lblReception.Text = "Date de récéption :";
            // 
            // lblReceptionEngin
            // 
            this.lblReceptionEngin.AutoSize = true;
            this.lblReceptionEngin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionEngin.Location = new System.Drawing.Point(434, 324);
            this.lblReceptionEngin.Name = "lblReceptionEngin";
            this.lblReceptionEngin.Size = new System.Drawing.Size(18, 24);
            this.lblReceptionEngin.TabIndex = 3;
            this.lblReceptionEngin.Text = "*";
            // 
            // lblNumeroEngin
            // 
            this.lblNumeroEngin.AutoSize = true;
            this.lblNumeroEngin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEngin.Location = new System.Drawing.Point(434, 291);
            this.lblNumeroEngin.Name = "lblNumeroEngin";
            this.lblNumeroEngin.Size = new System.Drawing.Size(18, 24);
            this.lblNumeroEngin.TabIndex = 3;
            this.lblNumeroEngin.Text = "*";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(158, 291);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(94, 24);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero :";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(597, 18);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(239, 25);
            this.cboCaserne.TabIndex = 2;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(446, 21);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(145, 17);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Choix de la caserne :";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(373, 653);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(90, 90);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.changerEngin);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(469, 653);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(90, 90);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.changerEngin);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(565, 653);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 90);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.changerEngin);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(661, 653);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(90, 90);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.changerEngin);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.grpEngins);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extinct\'Heure";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grpEngins.ResumeLayout(false);
            this.grpEngins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEngin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEngins;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblReception;
        private System.Windows.Forms.Label lblReparation;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.PictureBox pcbEngin;
        private System.Windows.Forms.CheckBox chkReparation;
        private System.Windows.Forms.CheckBox chkMission;
        private System.Windows.Forms.Label lblReceptionEngin;
        private System.Windows.Forms.Label lblNumeroEngin;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
    }
}

