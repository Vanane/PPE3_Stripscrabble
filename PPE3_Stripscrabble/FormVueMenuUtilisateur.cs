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
        private FormVueGestionListeSecteurs FVGS;
        private FormVueGestionListeRegions FVGR;
        private FormVueGestionListeLaboratoires FVGL;


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
            AfficheTexteAccueil();

            //On instancie les forms
            FVVU = new FormVueVoirUtilisateurs();
            FVGU = new FormVueGestionUtilisateur();
            FVGS = new FormVueGestionListeSecteurs();
            FVGR = new FormVueGestionListeRegions();
            FVGL = new FormVueGestionListeLaboratoires();
            ready = true;
        }

        private void ToolStripInfos_Click(object sender, EventArgs e)
        {
            FVGU.Dispose();
            FVGU = new FormVueGestionUtilisateur();
            FVGU.Show();
        }


        private void secteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVGS.Dispose();
            FVGS = new FormVueGestionListeSecteurs();
            FVGS.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVGR.Dispose();
            FVGR = new FormVueGestionListeRegions();
            FVGR.Show();
        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVGL.Show();
        }

        private void ToolStripFiltrer_Click(object sender, EventArgs e)
        {
            FVVU.Dispose();
            FVVU = new FormVueVoirUtilisateurs();
            FVVU.Show();
        }

        private void checkEstResponsable()
        {
            //On affecte des booléens à la visiblité des choix de gestion           
            laboratoireToolStripMenuItem.Visible = Modele.EstResponsable()[0];
            regionToolStripMenuItem.Visible = Modele.EstResponsable()[1];
            secteurToolStripMenuItem.Visible = Modele.EstResponsable()[2];
            
        }

        private void AfficheTexteAccueil()
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
