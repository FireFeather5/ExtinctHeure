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
using Pinpon;

namespace ExtinctHeure
{
    public partial class frmAccueil : Form
    {
        private SQLiteConnection cx;
        public frmAccueil()
        {
            InitializeComponent();
            try
            {
                this.cx = Connexion.Connec;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de l'accès à la DB : " + ex.Message);
            }
        }

        // On charge uniquement la combobox des Casernes dans le load
        private void frmAccueil_Load(object sender, EventArgs e)
        {
            ChargercboCasernes();
        }

        // Une fois une caserne choisi on récupère les pompiers associés à cette caserne
        private void cboCasernes_SelectedValueChanged(object sender, EventArgs e)
        {
            cboPompiers.Items.Clear();
            cboPompiers.Text = String.Empty;

            if (cboCasernes.Text != String.Empty)
            {
                ChargercboPompiers();
            }
        }

        // Quand on séléctionne un pompier on affiche ses données
        private void cboPompiers_SelectedValueChanged(object sender, EventArgs e)
        {
            grpInfosPompier.Visible = true;

            if (cboCasernes.Text != String.Empty)
            {
                ChargerInfosPompiers();
            }
        }

        private void btnPlusInfos_Click(object sender, EventArgs e)
        {
            btnPlusInfos.Visible = false;
            grpInfosCarriere.Visible = true;
        }


        // Fonctions pour charger les Casernes et les Pompiers dans la combobox
        private void ChargercboCasernes()
        {
            string req = "SELECT nom FROM Caserne";
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader caserneReader = cmd.ExecuteReader();
            while (caserneReader.Read())
            {
                string nomCaserne = caserneReader.GetString(0);
                this.cboCasernes.Items.Add(nomCaserne);
            }
        }

        private void ChargercboPompiers()
        {
            // On récupère uniquement les pompiers présent dans la caserne choisie
            string req = $@"SELECT P.nom, P.prenom FROM Pompier P
                            JOIN Affectation A ON P.matricule = A.matriculePompier
                            JOIN Caserne C ON A.idCaserne = C.id
                            WHERE C.nom = '{cboCasernes.Text}'";

            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader pompierReader = cmd.ExecuteReader();

            while (pompierReader.Read())
            {
                string nom = pompierReader.GetString(0);
                string prenom = pompierReader.GetString(1);
                this.cboPompiers.Items.Add(nom + ' ' + prenom);
            }
        }

        // On charge les infos des pompiers
        private void ChargerInfosPompiers()
        {
            grpInfosPerso.Controls.Clear();
            grpInfosCarriere.Controls.Clear();

            // On a besoin d'initialiser ces variables dans le cas où un nom de famille comporte un espace'
            string finalNom = "";
            string prenom = "";
            string req = "";

            string[] text = cboPompiers.Text.Split(' ');
            MessageBox.Show(text.Length.ToString());

            if (text.Length > 2)
            {
                for(int i = 0; i < text.Length - 1; i++)
                {
                    if (i == text.Length - 2)
                    {
                        finalNom += text[i].ToLower();
                    }
                    else
                    {
                        finalNom += text[i].ToLower() + " ";
                    }
                }
            }
            else
            {
                finalNom = text[0].ToLower();
            }
            
            prenom = cboPompiers.Text.Split(' ')[text.Length-1].ToLower();

            req = $"SELECT * FROM Pompier WHERE lower(nom) = '{finalNom}' AND lower(prenom) = '{prenom}'";
            MessageBox.Show(req);
            SQLiteCommand cmd = new SQLiteCommand(req, this.cx);
            SQLiteDataReader pompierReader = cmd.ExecuteReader();

            // Tableau des nom des colonnes
            string[] labels = {"Matricule", "Nom", "Prénom", "Sexe", "Date de Naissance",
                               "Type", "Portable", "Bip", "En Mission",
                               "En Conge", "Code grade", "Date d'embauche"};

            while (pompierReader.Read())
            {
                for (int i = 0; i < pompierReader.FieldCount; i++)
                {
                    Label lbl = new Label();

                    string valeur = "";
                    
                    // Pour les colonnes ayant pour valeur des entiers
                    if (pompierReader.GetFieldType(i).ToString() == "System.Int64")
                    {
                        // On personnalise ici l'affichage des valeurs pour éviter simplement des nombres
                        if (pompierReader.GetInt32(i) == 0)
                        {
                            valeur = "Non";
                        }
                        else if (pompierReader.GetInt32(i) == 1)
                        {
                            valeur = "Oui";
                        }
                        else
                        {
                            valeur = pompierReader.GetInt32(i).ToString();
                        }
                    }
                    else
                    {
                        // Pareil ici pour ne pas réduire le sexe à une seule lettre
                        if (pompierReader.GetString(i) == "m")
                        {
                            valeur = "Homme";
                        }
                        else if (pompierReader.GetString(i) == "f")
                        {
                            valeur = "Femme";
                        }
                        else
                        {
                            valeur = pompierReader.GetString(i);
                        }
                    }
                    
                    // Si on souhaite personnaliser les affichages des labels il faut les gérer individuellments
                    if (labels[i] == "Matricule")
                    {
                        // Ce label est isolé, il faut le gérer séparement des autres
                        lbl.Text = $"{labels[i]} : " + valeur;

                        // On créer une nouvelle font pour mettre le matricule en valeur
                        lbl.Font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
                        lbl.Top = 35;
                        lbl.Left = 250;
                        lbl.Width = lbl.Text.Length * 15;
                        
                        grpInfosPerso.Controls.Add(lbl);
                    }
                    else if (labels[i] == "Type")
                    {
                        // Ce label également isolé
                        lbl.Text = $"{labels[i]} : ";
                        lbl.Top = i * 35;
                        lbl.Left = 10;
                        lbl.Width = lbl.Text.Length * 7;
                        lbl.Height = 20;

                        // On gère le placement des deux RadioButton
                        RadioButton rdbProfessionel = new RadioButton();
                        rdbProfessionel.Top = (i * 35) - 2;
                        rdbProfessionel.Left = 75;
                        rdbProfessionel.Text = "Professionel";
                        rdbProfessionel.Width = rdbProfessionel.Text.Length * 10;
                        
                        RadioButton rdbVolontaire = new RadioButton();
                        rdbVolontaire.Top = (i * 35) - 2;
                        rdbVolontaire.Left = 210;
                        rdbVolontaire.Text = "Volontaire";

                        if (pompierReader.GetString(i) == "p")
                        {
                            rdbProfessionel.Checked = true;
                            rdbVolontaire.Enabled = false;
                        }
                        else
                        {
                            rdbVolontaire.Checked = true;
                            rdbProfessionel.Enabled = false;
                        }
                        grpInfosPerso.Controls.Add(lbl);
                        grpInfosPerso.Controls.Add(rdbProfessionel);
                        grpInfosPerso.Controls.Add(rdbVolontaire);
                    }
                    else
                    {
                        lbl.Text = $"{labels[i]} : " + valeur;
                        grpInfosPerso.Controls.Add(lbl);
                        lbl.Top = i * 35;
                        lbl.Left = 10;
                        lbl.Width = lbl.Text.Length * 12;
                        lbl.Height = 20;
                    }
                }
            }
        }

        private void pcbIconeQuit_Click(object sender, EventArgs e)
        {
            if (cx.State == ConnectionState.Open)
            {
                cx.Close();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
