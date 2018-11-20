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
    public partial class FAjoutMedicament : Form
    {
        List<MEDICAMENT> lesMedocs;

        public FAjoutMedicament()
        {
            InitializeComponent();
        }

        private void FAjoutMedicament_Load(object sender, EventArgs e)
        {
            if(Modele.getEtatMedoc() == true)
            {
                NUDQtt.Visible = false;
                lblQtt.Visible = false;
            }
            else
            {
                NUDQtt.Visible = true;
                lblQtt.Visible = true;
            }
            lesMedocs = new List<MEDICAMENT>();
            foreach (MEDICAMENT m in Modele.listMedoc())
            {
                cbListMedoc.Items.Add(m.nomCommercial);
                this.lesMedocs.Add(m);
            }
        }

        private void cbListMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFamileMedocSelect.Text = lesMedocs[cbListMedoc.SelectedIndex].FAMILLE.libFamille;
            lblNomMedocSelect.Text = lesMedocs[cbListMedoc.SelectedIndex].nomCommercial;
        }

        private void btnAnnulerAjoutMedoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
