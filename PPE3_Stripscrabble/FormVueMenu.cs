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
    public partial class FormVueMenu : Form
    {
        public FormVueMenu()
        {
            InitializeComponent();
        }

        private void FormVueMenu_Load(object sender, EventArgs e)
        {
            lblTest.Text = string.Format("Bienvenue sur l'application GSB, {0} {1}", Modele.getPrenom(), Modele.getNom());
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Modele.resetConnexion();
            //On crée un nouveau thread pour lancer la form Connexion, avant de fermer ce thread-ci.
            System.Threading.Thread t = new System.Threading.Thread(
                    new System.Threading.ThreadStart(ThreadConnexion));
            t.Start();
            this.Close();
        }
        public static void ThreadConnexion()
        {
            Application.Run(new FormVueConnexionUtilisateur());
        }

        private void buttonFormVanane_Click(object sender, EventArgs e)
        {
            FormVueGestionUtilisateur FVGU = new FormVueGestionUtilisateur();
            FVGU.Show();
        }
    }
}
