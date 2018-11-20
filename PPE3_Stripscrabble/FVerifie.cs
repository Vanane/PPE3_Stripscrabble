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
    public partial class FVerifie : Form
    {
        public FVerifie()
        {
            InitializeComponent(); //Besoin de charger la BD et les demandes enregistrées
        
        }

        private void FVerifie_Load(object sender, EventArgs e)
        {
            //Récuperer toutes les demandes en cours d'une personne
            fichefrais f = Modele.getLaFicheEnDate();
            dgvficheFrais.DataSource = Modele.getLaFicheFrais();

        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            Modele.setTypeDemande("modifier");
            FDemande Demande = new FDemande();
            Demande.Show();

            // Retrouver l'id du compositeur choisi pour faire fonctionner la méthode de Modele qui retourne un compositeur à partir de l'id
            // System.Type type = bsCompositeur.Current.GetType();
            //  int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompositeur.Current, null);

            //Modification variables actionGestionCompositeur et CompositeurChoisi
            // SELECT NomCompo et à partir de là on recup' l'id du nom -> On utlise la mméthode de Modele

            // Modele.CompositeurChoisi = Modele.CompositeurParId(id);

            // FAjoutModifCompositeur Modif = new FAjoutModifCompositeur();



            // Quand on clique ça doit : Afficher une form où on a recuperer les informations selectionnées ds le dgv
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            // Enregistre les données + ferme la page
            this.Close();        
        }

        private void labForfait_Click(object sender, EventArgs e)
        {

        }
    }
}
