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
    public partial class FormVueInfoVisiteur : Form
    {
        private Visiteur LeVisiteur;
        private FormVueAjoutSupprAffectation FVASA;
        public FormVueInfoVisiteur()
        {
            InitializeComponent();
        }
        public FormVueInfoVisiteur(Visiteur v)
        {
            InitializeComponent();
            LeVisiteur = v;
        }

        private void FormVueInfoVisiteur_Load(object sender, EventArgs e)
        {
            this.Text = "Informations de" + LeVisiteur.NomComplet;
            textBoxIdV.Text = LeVisiteur.idVisiteur;
            textBoxNomV.Text = LeVisiteur.nom;
            textBoxPrenomV.Text = LeVisiteur.prenom;


            DGVRegions.DataSource = LeVisiteur.Region.Select(x => new{ID = x.idRegion, Libellé = x.libRegion, Responsable = x.VisiteurResp.NomComplet}).ToList();
            lblTitreDGV.Text = "Régions dans lesquelles travaille " + LeVisiteur.NomComplet + " :";

            FVASA = new FormVueAjoutSupprAffectation();
        }

        private void btnAjoutSuppr_Click(object sender, EventArgs e)
        {
            OuvreFormAjoutSuppr("supprimer");
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            OuvreFormAjoutSuppr("ajouter");
        }


        private void OuvreFormAjoutSuppr(string s)
        {
            //Détruit un objet Form, puis le redéclare, évitant ainsi d'ouvrir la form plusieurs fois.
            //la Form demande un string et un Visiteur pour savoir quel visiteur traiter, et pour quelle opération (ajouter/supprimer)
            FVASA.Dispose();
            FVASA = new FormVueAjoutSupprAffectation(LeVisiteur, s);
            FVASA.Show();
        }
    }
}
