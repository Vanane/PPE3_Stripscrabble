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
        }

        private void comboBoxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
