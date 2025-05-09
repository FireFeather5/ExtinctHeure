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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
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
            this.bnNavigation = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grpEngins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEngin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnNavigation)).BeginInit();
            this.bnNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEngins
            // 
            this.grpEngins.Controls.Add(this.bnNavigation);
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
            this.grpEngins.Size = new System.Drawing.Size(1043, 476);
            this.grpEngins.TabIndex = 0;
            this.grpEngins.TabStop = false;
            this.grpEngins.Text = "Liste des engins";
            // 
            // chkReparation
            // 
            this.chkReparation.AutoSize = true;
            this.chkReparation.Enabled = false;
            this.chkReparation.Location = new System.Drawing.Point(282, 317);
            this.chkReparation.Name = "chkReparation";
            this.chkReparation.Size = new System.Drawing.Size(15, 14);
            this.chkReparation.TabIndex = 5;
            this.chkReparation.UseVisualStyleBackColor = true;
            // 
            // chkMission
            // 
            this.chkMission.AutoSize = true;
            this.chkMission.Enabled = false;
            this.chkMission.Location = new System.Drawing.Point(282, 283);
            this.chkMission.Name = "chkMission";
            this.chkMission.Size = new System.Drawing.Size(15, 14);
            this.chkMission.TabIndex = 5;
            this.chkMission.UseVisualStyleBackColor = true;
            // 
            // pcbEngin
            // 
            this.pcbEngin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbEngin.Location = new System.Drawing.Point(733, 94);
            this.pcbEngin.Name = "pcbEngin";
            this.pcbEngin.Size = new System.Drawing.Size(250, 250);
            this.pcbEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbEngin.TabIndex = 4;
            this.pcbEngin.TabStop = false;
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
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(146, 281);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(89, 17);
            this.lblMission.TabIndex = 3;
            this.lblMission.Text = "En mission :";
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
            // lblReceptionEngin
            // 
            this.lblReceptionEngin.AutoSize = true;
            this.lblReceptionEngin.Location = new System.Drawing.Point(283, 139);
            this.lblReceptionEngin.Name = "lblReceptionEngin";
            this.lblReceptionEngin.Size = new System.Drawing.Size(14, 17);
            this.lblReceptionEngin.TabIndex = 3;
            this.lblReceptionEngin.Text = "*";
            // 
            // lblNumeroEngin
            // 
            this.lblNumeroEngin.AutoSize = true;
            this.lblNumeroEngin.Location = new System.Drawing.Point(283, 106);
            this.lblNumeroEngin.Name = "lblNumeroEngin";
            this.lblNumeroEngin.Size = new System.Drawing.Size(14, 17);
            this.lblNumeroEngin.TabIndex = 3;
            this.lblNumeroEngin.Text = "*";
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
            // bnNavigation
            // 
            this.bnNavigation.AddNewItem = null;
            this.bnNavigation.CountItem = this.bindingNavigatorCountItem;
            this.bnNavigation.DeleteItem = null;
            this.bnNavigation.Dock = System.Windows.Forms.DockStyle.None;
            this.bnNavigation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnNavigation.Location = new System.Drawing.Point(417, 448);
            this.bnNavigation.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnNavigation.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnNavigation.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnNavigation.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnNavigation.Name = "bnNavigation";
            this.bnNavigation.PositionItem = this.bindingNavigatorPositionItem;
            this.bnNavigation.Size = new System.Drawing.Size(202, 25);
            this.bnNavigation.TabIndex = 6;
            this.bnNavigation.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            ((System.ComponentModel.ISupportInitialize)(this.bnNavigation)).EndInit();
            this.bnNavigation.ResumeLayout(false);
            this.bnNavigation.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator bnNavigation;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

