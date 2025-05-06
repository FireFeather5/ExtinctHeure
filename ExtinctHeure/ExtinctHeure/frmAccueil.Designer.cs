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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumMis = new System.Windows.Forms.Label();
            this.lblDteMis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.btnAnn = new System.Windows.Forms.Button();
            this.btnConstEqu = new System.Windows.Forms.Button();
            this.cboNatSin = new System.Windows.Forms.ComboBox();
            this.cboCasMob = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDteMis);
            this.groupBox1.Controls.Add(this.lblNumMis);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(29, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVille);
            this.groupBox2.Controls.Add(this.txtCP);
            this.groupBox2.Controls.Add(this.txtRue);
            this.groupBox2.Controls.Add(this.txtMotif);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1151, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations usager";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboCasMob);
            this.groupBox3.Controls.Add(this.cboNatSin);
            this.groupBox3.Controls.Add(this.btnConstEqu);
            this.groupBox3.Controls.Add(this.btnAnn);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(30, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1151, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Décisions du régulateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(797, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse sinistre";
            // 
            // lblNumMis
            // 
            this.lblNumMis.AutoSize = true;
            this.lblNumMis.Location = new System.Drawing.Point(269, 28);
            this.lblNumMis.Name = "lblNumMis";
            this.lblNumMis.Size = new System.Drawing.Size(78, 22);
            this.lblNumMis.TabIndex = 3;
            this.lblNumMis.Text = "Mission n°";
            // 
            // lblDteMis
            // 
            this.lblDteMis.AutoSize = true;
            this.lblDteMis.Location = new System.Drawing.Point(712, 28);
            this.lblDteMis.Name = "lblDteMis";
            this.lblDteMis.Size = new System.Drawing.Size(110, 22);
            this.lblDteMis.TabIndex = 4;
            this.lblDteMis.Text = "déclenchée le : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nature du siniste";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Caserne à mobiliser";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(274, 54);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(198, 28);
            this.txtMotif.TabIndex = 5;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(751, 54);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(198, 28);
            this.txtRue.TabIndex = 6;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(751, 88);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(198, 28);
            this.txtCP.TabIndex = 7;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(751, 122);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(198, 28);
            this.txtVille.TabIndex = 8;
            // 
            // btnAnn
            // 
            this.btnAnn.Location = new System.Drawing.Point(895, 109);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(122, 61);
            this.btnAnn.TabIndex = 8;
            this.btnAnn.Text = "Annuler";
            this.btnAnn.UseVisualStyleBackColor = true;
            // 
            // btnConstEqu
            // 
            this.btnConstEqu.Location = new System.Drawing.Point(1023, 109);
            this.btnConstEqu.Name = "btnConstEqu";
            this.btnConstEqu.Size = new System.Drawing.Size(122, 61);
            this.btnConstEqu.TabIndex = 9;
            this.btnConstEqu.Text = "Constituer équipe";
            this.btnConstEqu.UseVisualStyleBackColor = true;
            // 
            // cboNatSin
            // 
            this.cboNatSin.FormattingEnabled = true;
            this.cboNatSin.Location = new System.Drawing.Point(296, 49);
            this.cboNatSin.Name = "cboNatSin";
            this.cboNatSin.Size = new System.Drawing.Size(193, 30);
            this.cboNatSin.TabIndex = 10;
            // 
            // cboCasMob
            // 
            this.cboCasMob.FormattingEnabled = true;
            this.cboCasMob.Location = new System.Drawing.Point(850, 48);
            this.cboCasMob.Name = "cboCasMob";
            this.cboCasMob.Size = new System.Drawing.Size(193, 30);
            this.cboCasMob.TabIndex = 11;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 696);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccueil";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDteMis;
        private System.Windows.Forms.Label lblNumMis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConstEqu;
        private System.Windows.Forms.Button btnAnn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.ComboBox cboCasMob;
        private System.Windows.Forms.ComboBox cboNatSin;
    }
}

