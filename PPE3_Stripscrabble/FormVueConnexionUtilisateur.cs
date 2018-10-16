using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_Stripscrabble
{
    public partial class FormVueConnexionUtilisateur : Form
    {
        public FormVueConnexionUtilisateur()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            if (textBoxIdentifiant.Text != "" && textBoxMDP.Text != "" &&
                Modele.verifierConnexion(textBoxIdentifiant.Text, textBoxMDP.Text)) //Si les données sont valides
            {
                Console.WriteLine("Utilisateur Connecté");
                MessageBox.Show(("Vous êtes connnecté ! Bienvenue, " + Modele.getIdentifiant() + " !"), "Connexion Établie", MessageBoxButtons.OK);

                //On crée un nouveau thread pour lancer le menu, avant de fermer ce thread-ci.
                System.Threading.Thread t = new System.Threading.Thread(
                        new System.Threading.ThreadStart(ThreadMenu));
                t.Start();

                this.Close();
            }
            else
            {
                //Sinon, si les valeurs sont nulles....
                MessageBox.Show("L'identifiant ou le mot de passe est incorrect.", "   Erreur de saisie   ", MessageBoxButtons.OK);
            }             
        }

        public static void ThreadMenu()
        {
            Application.Run(new FormVueMenu());
        }


    }
}
