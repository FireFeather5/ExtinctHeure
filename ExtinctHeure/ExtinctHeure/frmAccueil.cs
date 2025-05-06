using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtinctHeure
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        DataSet monDS = MesDatas.DsGlobal;

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            SQLiteConnection cx = Connexion.Connec;
        }
    }

    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();

        public static DataSet DsGlobal { get { return MesDatas.dsGlobal; } }

    }

    internal class Connexion
    {
        // Objet Connection
        private static SQLiteConnection connec;

        // Constructeur privé pour empêcher l'instanciation directe depuis l'extérieur.
        private Connexion() { }

        // Méthode publique pour obtenir l'instance unique de la classe.
        public static SQLiteConnection Connec
        {
            get
            {
                // Si l'instance n'existe pas, on la crée.
                if (connec == null)
                {
                    try
                    {
                        // Chaîne de connexion à votre base de données
                        string chaine = @"Data Source = ..\..\..\SDIS67.db";
                        connec = new SQLiteConnection(chaine);
                        connec.Open();
                    }
                    catch (SQLiteException err)
                    {
                        Console.WriteLine($"Erreur lors de l'ouverture de la connexion : {err.Message}");
                    }
                }
                //Dans tous les cas on renvoie la connexion
                return connec;
            }
        }

        // Méthode pour fermer proprement la connexion
        public static void FermerConnexion()
        {
            if (connec != null)
            {
                try
                {
                    connec.Close();
                    connec.Dispose();
                    connec = null; // Libération pour permettre une nouvelle connexion propre
                }
                catch (Exception err)
                {
                    Console.WriteLine($"Erreur lors de la fermeture de la connexion : {err.Message}");
                }
            }
        }
    }
}
