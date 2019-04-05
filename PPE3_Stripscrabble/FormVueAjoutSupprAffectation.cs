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

                    comboBoxRegions.DataSource = Modele.lesRegions();

                    break;
                case "suppprimer":
                    lblRegion.Text = "Choisissez une Région à supprimer :";

                    comboBoxRegions.DataSource = LeVisiteur.Region;

                    break;


            }
        }
    }
}
