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
            if (saisieValide()) //Si le login et le mot de passe sont entrés
            {
                if (Modele.verifierConnexion(textBoxIdentifiant.Text, textBoxMDP.Text)) //Si les données sont valides
                {
                    //Faire Se Connecter
                }
            }
            else
            {
                //Sinon les valeurs sont nulles.
                MessageBox.Show("L'identifiant ou le mot de passe est incorrect.", "   Erreur de saisie   ", MessageBoxButtons.OK);

            }
             
        }

        private bool saisieValide()
        {
            if (textBoxIdentifiant.Text != "" && textBoxMDP.Text != "")
                return true;
            else
                return false;
        }
    }
}
