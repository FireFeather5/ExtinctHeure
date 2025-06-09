using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtinctHeureUC
{
    public partial class Stats : UserControl
    {
        private int hauteur = 0;

        public Stats()
        {
            InitializeComponent();
        }

        public Stats(String colonneGauche, String colonneDroite)
        {
            InitializeComponent();
            this.lblColonneGauche.Text = colonneGauche;
            this.lblColonneDroite.Text = colonneDroite;
        }

        [Description("Entete de la colonne de gauche")]
        public String ColonneGauche
        {
            get
            {
                return this.lblColonneGauche.Text;
            }
            set
            {
                this.lblColonneGauche.Text = value;
            }
        }

        [Description("Entete de la colonne de droite")]
        public String ColonneDroite
        {
            get
            {
                return this.lblColonneDroite.Text;
            }
            set
            {
                this.lblColonneDroite.Text = value;
            }
        }

        public void AjouterLigne(String valeurGauche, String valeurDroite)
        {
            Label lblGauche = new Label()
            {
                Text = valeurGauche,
                MaximumSize = new Size(177, 0),
                AutoSize = true,
                Location = new Point(0, hauteur),
                TextAlign = ContentAlignment.MiddleLeft,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblDroite = new Label()
            {
                Text = valeurDroite,
                MaximumSize = new Size(177, 0),
                AutoSize = true,
                Location = new Point(177, hauteur),
                TextAlign = ContentAlignment.MiddleLeft,
                BorderStyle = BorderStyle.FixedSingle
            };

            pnlStats.Controls.Add(lblGauche);
            pnlStats.Controls.Add(lblDroite);

            int hauteurMax = Math.Max(lblGauche.Height, lblDroite.Height);

            lblDroite.MinimumSize = new Size(177, hauteurMax);
            lblGauche.MinimumSize = new Size(177, hauteurMax);

            hauteur += hauteurMax;
        }

        public void Clear()
        {
            pnlStats.Controls.Clear();
            hauteur = 0;
        }
    }
}
