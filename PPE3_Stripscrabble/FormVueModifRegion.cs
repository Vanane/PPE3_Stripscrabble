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
    public partial class FormVueModifRegion : Form
    {
        private Secteur leSecteur;
        public FormVueModifRegion(Secteur s)
        {
            InitializeComponent();
            leSecteur = s;
        }
        private void FormVueModifRegion_Load(object sender, EventArgs e)
        {
            comboBoxRegions.ValueMember = "idRegion";
            comboBoxRegions.DisplayMember = "libRegion";
            comboBoxRegions.DataSource = Modele.RegionsParSecteur(leSecteur);

            comboBoxVisiteurs.ValueMember = "idVisiteur";
            comboBoxVisiteurs.DisplayMember = "nom";
            comboBoxVisiteurs.DataSource = Modele.LesVisiteurs();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (comboBoxRegions.SelectedIndex != -1 && comboBoxVisiteurs.SelectedIndex != -1)
            {
                MessageBox.Show(Modele.ChangeRespRegion((Region)comboBoxRegions.SelectedItem, (Visiteur)comboBoxVisiteurs.SelectedItem), "Résultat");
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez choisir tous les champs !", "Erreur de saisie");                               
            }
        }
    }
}
