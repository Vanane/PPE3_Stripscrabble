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
    public partial class FormVueMenuUtilisateur : Form
    {
        private bool ready;
        private FormVueVoirUtilisateurs FVVU;
        private FormVueGestionUtilisateur FVGU;
        private FormVueGestionSecteur FVGS;
        /*private FormVueGestionRegion FVGR;*/
        /*private FormVueGestionLabo FVGL;*/


        public FormVueMenuUtilisateur()
        {
            InitializeComponent();
            ready = false;
        }

        private void FormVueMenuUtilisateur_Load(object sender, EventArgs e)
        {
            foreach(ToolStripMenuItem t in ToolStripGerer.DropDownItems)
            {
                t.Visible = false;
            }
            //Appel à la méthode qui permet de masquer les options inutiles
            checkEstResponsable();

            //Appel à la méthode pour afficher le texte d'accueil
            afficheTexteAccueil();

            //On instancie les forms
            FVVU = new FormVueVoirUtilisateurs();
            FVGU = new FormVueGestionUtilisateur();
            FVGS = new FormVueGestionSecteur();
            /*FVGR = new FormVueGestionRegion()*/
            /*FVGL new FormVueGestionLabo()*/

            ready = true;
        }

        private void ToolStripInfos_Click(object sender, EventArgs e)
        {
            FVGU.Show();
        }


        private void secteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVGS.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FGVR.Show();*/
        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FGVL.Show();*/
        }

        private void ToolStripFiltrer_Click(object sender, EventArgs e)
        {
            FVVU.Show();
        }
        private void checkEstResponsable()
        {
            bool[] lesResp = Modele.getLesResponsabilites();
            //Renvoie un tableau de booléens qui contiennent les responsabilités d'un user

            //On affecte ces booléens à la visiblité des choix de gestion
            laboratoireToolStripMenuItem.Visible = lesResp[0];
            regionToolStripMenuItem.Visible = lesResp[1];
            secteurToolStripMenuItem.Visible = lesResp[2];
        }

        private void afficheTexteAccueil()
        {
            lblTexte.Text = "Bienvenue sur l'interface de gestion.\n" +
                "Vous pouvez accéder, à l'aide de la barre de menu ci-dessus, aux informations de l'application.\n" +
                "\"Informations utilisateur\" vous permet de consulter vos informations et de modifier votre mot de passe.\n" +
                "\"Voir les utilisateurs\" contient la liste des utilisateurs en fonction du secteur ou de la région choisie.\n" +
                "\"Gestion\" contient une liste de choix, visibles ou non, en fonction de vos responsabilités : Secteur, Région et Laboratoire :\n\n" +
                "       - \"Secteur\" permet de gérer le secteur duquel vous êtes responsable.\n" +
                "       - \"Région\" permet de gérer la région de la même façon.\n" +
                "       - \"Laboratoire\" permet de gérer le laboratoire que vous dirigez.\n";



        }
    }
}
