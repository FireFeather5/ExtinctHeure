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
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnFIrst = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblReception = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblReparation = new System.Windows.Forms.Label();
            this.pcbEngin = new System.Windows.Forms.PictureBox();
            this.grpEngins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEngins
            // 
            this.grpEngins.Controls.Add(this.pcbEngin);
            this.grpEngins.Controls.Add(this.lblReparation);
            this.grpEngins.Controls.Add(this.lblMission);
            this.grpEngins.Controls.Add(this.lblReception);
            this.grpEngins.Controls.Add(this.lblNumero);
            this.grpEngins.Controls.Add(this.cboCaserne);
            this.grpEngins.Controls.Add(this.lblCaserne);
            this.grpEngins.Controls.Add(this.btnLast);
            this.grpEngins.Controls.Add(this.btnRight);
            this.grpEngins.Controls.Add(this.btnLeft);
            this.grpEngins.Controls.Add(this.btnFIrst);
            this.grpEngins.Location = new System.Drawing.Point(12, 100);
            this.grpEngins.Name = "grpEngins";
            this.grpEngins.Size = new System.Drawing.Size(1043, 476);
            this.grpEngins.TabIndex = 0;
            this.grpEngins.TabStop = false;
            this.grpEngins.Text = "Liste des engins";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(485, 18);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(239, 25);
            this.cboCaserne.TabIndex = 2;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(334, 21);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(145, 17);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Choix de la caserne :";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(598, 400);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(70, 70);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(522, 400);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 70);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(446, 400);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(70, 70);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnFIrst
            // 
            this.btnFIrst.Location = new System.Drawing.Point(370, 400);
            this.btnFIrst.Name = "btnFIrst";
            this.btnFIrst.Size = new System.Drawing.Size(70, 70);
            this.btnFIrst.TabIndex = 0;
            this.btnFIrst.Text = "|<";
            this.btnFIrst.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(146, 106);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(68, 17);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero :";
            // 
            // lblReception
            // 
            this.lblReception.AutoSize = true;
            this.lblReception.Location = new System.Drawing.Point(146, 139);
            this.lblReception.Name = "lblReception";
            this.lblReception.Size = new System.Drawing.Size(131, 17);
            this.lblReception.TabIndex = 3;
            this.lblReception.Text = "Date de récéption :";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(146, 281);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(89, 17);
            this.lblMission.TabIndex = 3;
            this.lblMission.Text = "En mission :";
            // 
            // lblReparation
            // 
            this.lblReparation.AutoSize = true;
            this.lblReparation.Location = new System.Drawing.Point(146, 314);
            this.lblReparation.Name = "lblReparation";
            this.lblReparation.Size = new System.Drawing.Size(103, 17);
            this.lblReparation.TabIndex = 3;
            this.lblReparation.Text = "En réparation :";
            // 
            // pcbEngin
            // 
            this.pcbEngin.Location = new System.Drawing.Point(733, 94);
            this.pcbEngin.Name = "pcbEngin";
            this.pcbEngin.Size = new System.Drawing.Size(250, 250);
            this.pcbEngin.TabIndex = 4;
            this.pcbEngin.TabStop = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.grpEngins);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.Text = "Extinct\'Heure";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.grpEngins.ResumeLayout(false);
            this.grpEngins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEngin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEngins;
        private System.Windows.Forms.Button btnFIrst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblReception;
        private System.Windows.Forms.Label lblReparation;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.PictureBox pcbEngin;
    }
}

