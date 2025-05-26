namespace ExtinctHeure
{
    partial class frmAjoutPompier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutPompier));
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblTypePompier = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.calDateNaissance = new System.Windows.Forms.MonthCalendar();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.chklstHabilitations = new System.Windows.Forms.CheckedListBox();
            this.pnlSexe = new System.Windows.Forms.Panel();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboGrades = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSexe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmer.Location = new System.Drawing.Point(889, 475);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(125, 50);
            this.btnConfirmer.TabIndex = 0;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnuler.Location = new System.Drawing.Point(689, 475);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(125, 50);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(427, 30);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(226, 32);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Nouveau pompier";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(60, 100);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(51, 17);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(60, 135);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(72, 17);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prenom : ";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(60, 205);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(142, 17);
            this.lblDateNaissance.TabIndex = 6;
            this.lblDateNaissance.Text = "Date de naissance : ";
            // 
            // lblTypePompier
            // 
            this.lblTypePompier.AutoSize = true;
            this.lblTypePompier.Location = new System.Drawing.Point(60, 410);
            this.lblTypePompier.Name = "lblTypePompier";
            this.lblTypePompier.Size = new System.Drawing.Size(75, 17);
            this.lblTypePompier.TabIndex = 7;
            this.lblTypePompier.Text = "Pompier : ";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(60, 460);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(159, 17);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "Numéro de téléphone : ";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(574, 135);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(186, 17);
            this.lblCaserne.TabIndex = 9;
            this.lblCaserne.Text = "Caserne de rattachement : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 97);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 24);
            this.txtNom.TabIndex = 10;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(130, 132);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(140, 24);
            this.txtPrenom.TabIndex = 11;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // calDateNaissance
            // 
            this.calDateNaissance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calDateNaissance.Location = new System.Drawing.Point(214, 205);
            this.calDateNaissance.MaxSelectionCount = 1;
            this.calDateNaissance.Name = "calDateNaissance";
            this.calDateNaissance.TabIndex = 14;
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbProfessionnel.Location = new System.Drawing.Point(140, 408);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(115, 21);
            this.rdbProfessionnel.TabIndex = 15;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbVolontaire.Location = new System.Drawing.Point(270, 408);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(89, 21);
            this.rdbVolontaire.TabIndex = 16;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(252, 457);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ShortcutsEnabled = false;
            this.txtTelephone.Size = new System.Drawing.Size(140, 24);
            this.txtTelephone.TabIndex = 17;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephone_KeyPress);
            // 
            // cboCasernes
            // 
            this.cboCasernes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCasernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(766, 132);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(180, 24);
            this.cboCasernes.TabIndex = 18;
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(574, 261);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(98, 17);
            this.lblHabilitations.TabIndex = 19;
            this.lblHabilitations.Text = "Habilitations : ";
            // 
            // chklstHabilitations
            // 
            this.chklstHabilitations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chklstHabilitations.FormattingEnabled = true;
            this.chklstHabilitations.Location = new System.Drawing.Point(678, 261);
            this.chklstHabilitations.Name = "chklstHabilitations";
            this.chklstHabilitations.Size = new System.Drawing.Size(374, 175);
            this.chklstHabilitations.TabIndex = 20;
            // 
            // pnlSexe
            // 
            this.pnlSexe.Controls.Add(this.rdbFemme);
            this.pnlSexe.Controls.Add(this.rdbHomme);
            this.pnlSexe.Controls.Add(this.lblSexe);
            this.pnlSexe.Location = new System.Drawing.Point(38, 162);
            this.pnlSexe.Name = "pnlSexe";
            this.pnlSexe.Size = new System.Drawing.Size(260, 30);
            this.pnlSexe.TabIndex = 21;
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFemme.Location = new System.Drawing.Point(165, 8);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.Size = new System.Drawing.Size(77, 21);
            this.rdbFemme.TabIndex = 16;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbHomme.Location = new System.Drawing.Point(80, 8);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.Size = new System.Drawing.Size(78, 21);
            this.rdbHomme.TabIndex = 15;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(22, 9);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(53, 17);
            this.lblSexe.TabIndex = 14;
            this.lblSexe.Text = "Sexe : ";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(574, 198);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(60, 17);
            this.lblGrade.TabIndex = 22;
            this.lblGrade.Text = "Grade : ";
            // 
            // cboGrades
            // 
            this.cboGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrades.FormattingEnabled = true;
            this.cboGrades.Location = new System.Drawing.Point(678, 198);
            this.cboGrades.Name = "cboGrades";
            this.cboGrades.Size = new System.Drawing.Size(180, 24);
            this.cboGrades.TabIndex = 23;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAjoutPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1082, 558);
            this.Controls.Add(this.cboGrades);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.pnlSexe);
            this.Controls.Add(this.chklstHabilitations);
            this.Controls.Add(this.lblHabilitations);
            this.Controls.Add(this.cboCasernes);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.rdbVolontaire);
            this.Controls.Add(this.rdbProfessionnel);
            this.Controls.Add(this.calDateNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblTypePompier);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Font = new System.Drawing.Font("Arial", 10.8F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAjoutPompier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau pompier";
            this.Load += new System.EventHandler(this.frmAjoutPompier_Load);
            this.pnlSexe.ResumeLayout(false);
            this.pnlSexe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblTypePompier;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.MonthCalendar calDateNaissance;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.ComboBox cboCasernes;
        private System.Windows.Forms.Label lblHabilitations;
        private System.Windows.Forms.CheckedListBox chklstHabilitations;
        private System.Windows.Forms.Panel pnlSexe;
        private System.Windows.Forms.RadioButton rdbFemme;
        private System.Windows.Forms.RadioButton rdbHomme;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrades;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}