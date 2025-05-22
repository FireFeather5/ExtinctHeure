using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtinctHeureUC
{

    public delegate void ClotureMission(object sender, EventArgs e);
    public delegate void CreerRapport(object sender, EventArgs e);

    public partial class Mission : UserControl
    {
        bool fini = false;
        public Mission()
        {
            InitializeComponent();
        }

        [Description("ID de la mission")]
        public int idMission
        {
            get{
                return Convert.ToInt32(this.lblId.Text);
            }
            set{
                this.lblId.Text = value.ToString();
            }
        }

        [Description("Date de début de la mission")]
        public String debutMission
        {
            get
            {
                return this.lblDebut.Text;
            }
            set
            {
                this.lblDebut.Text = value;
            }
        }

        [Description("Caserne affectée à la mission")]
        public String caserne
        {
            get
            {
                return this.lblCaserne.Text;
            }
            set
            {
                this.lblCaserne.Text = value;
            }
        }

        [Description("Nature de la mission")]
        public String natureMission
        {
            get
            {
                return this.lblNatureMission.Text;
            }
            set
            {
                this.lblNatureMission.Text = value;
            }
        }

        [Description("Nom de la mission")]
        public String nomMission
        {
            get
            {
                return this.lblNomMission.Text;
            }
            set
            {
                this.lblNomMission.Text = value;
            }
        }

        [Description("Image de la mission")]
        public Image imageMission
        {
            get
            {
                return this.pcbImageMission.Image;
            }
            set
            {
                this.pcbImageMission.Image = value;
            }
        }

        [Description("Etat de la mission")]
        public bool estFini
        {
            get
            {
                return this.fini;
            }
            set
            {
                this.fini = value;
            }
        }

        String dateFin = "";

        [Description("Date de fin de la mission")]
        public String finMission
        {
            get
            {
                return this.dateFin;
            }
            set
            {
                this.dateFin = value;
            }
        }

        String adresse = "";

        [Description("Adresse de la mission")]
        public String adresseMission
        {
            get
            {
                return this.adresse;
            }
            set
            {
                this.adresse = value;
            }
        }

        String rapport = "";

        [Description("Rapport de la mission")]
        public String rapportMission
        {
            get
            {
                return this.rapport;
            }
            set
            {
                this.rapport = value;
            }
        }

        public ClotureMission ClotureMissionEvent;
        public CreerRapport CreerRapportEvent;

        private void btnCloture_Click(object sender, EventArgs e)
        {
            if (this.ClotureMissionEvent != null)
            {
                this.ClotureMissionEvent(this, e);
            }
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            if (this.CreerRapportEvent != null)
            {
                this.CreerRapportEvent(this, e);
            }
        }
    }
}
