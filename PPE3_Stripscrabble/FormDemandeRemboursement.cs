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
            FDemande Demande = new FDemande();
            Demande.Show();


        }

        private void cLOTURERUNEDEMANDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCloture Cloture = new FCloture();
            
            Cloture.Show();
        }

        private void vERIFIERUNEDEMANDEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
