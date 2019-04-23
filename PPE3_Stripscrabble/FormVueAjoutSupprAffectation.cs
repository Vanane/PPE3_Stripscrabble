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
    public partial class FormVueAjoutSupprAffectation : Form
    {
        private Visiteur LeVisiteur;
        private string TypeOpe;

        public FormVueAjoutSupprAffectation()
        {
            InitializeComponent();
        }

        public FormVueAjoutSupprAffectation(Visiteur v, string s)
        {
            InitializeComponent();
            LeVisiteur = v;
            TypeOpe = s;
        }

        private void FormVueAjoutSupprAffectation_Load(object sender, EventArgs e)
        {
            comboBoxRegions.DisplayMember = "libRegion";
            comboBoxRegions.ValueMember = "idRegion";

            switch (TypeOpe)
            {
                case "ajouter":
                    lblRegion.Text = "Choisissez une Région à ajouter :";

                    comboBoxRegions.DataSource = Modele.LesRegions().Where(x => !x.Visiteurs.Contains(LeVisiteur)).ToList();
                    break;
                case "supprimer":
                    lblRegion.Text = "Choisissez une Région à supprimer :";

                    comboBoxRegions.DataSource = LeVisiteur.Region.ToList();
                    break;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string texte = "";
            string titre = "";
            Region UneRegion = (Region)comboBoxRegions.SelectedItem;
            switch (TypeOpe)
            {
                case "ajouter":
                    titre = "Ajout Région";
                    texte = "Région " + UneRegion.libRegion + " ajoutée au visiteur " + LeVisiteur.NomComplet + "!";

                    if (Modele.AjouteUneRegionAUnVisiteur(LeVisiteur, UneRegion))
                        texte = "La Région " + UneRegion.libRegion + " existe déjà !";
                    break;
                case "supprimer":
                    titre = "Suppression Région";
                    texte = "Région " + UneRegion.libRegion + " supprimée au visiteur " + LeVisiteur.NomComplet + "!";

                    if (Modele.RetireUneRegionAUnVisiteur(LeVisiteur, UneRegion))
                        texte = "La Région " + UneRegion.libRegion + " a déjà été supprimée !";
                    break;
            }
            MessageBox.Show(texte,titre);
            this.Close();
        }
    }
}
