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
    public partial class FormDemandeRemboursement : Form
    {
        public FormDemandeRemboursement()
        {
            InitializeComponent();
        }

        private void dEMANDEDEREMBOURSEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modele.setTypeDemande("ajouter");
            FDemande Demande = new FDemande();
            Demande.Show();


        }

        private void vERIFIERUNEDEMANDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVerifie Verifie = new FVerifie();
            Verifie.Show();
        }

        private void cONSULTERUNEDEMANDEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
