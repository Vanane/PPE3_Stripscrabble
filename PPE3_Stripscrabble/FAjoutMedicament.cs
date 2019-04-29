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
        public FAjoutMedicament()
        {
            InitializeComponent();
        }

        private void FAjoutMedicament_Load(object sender, EventArgs e)
        {
            bsAjoutMed.DataSource = Modele.listMedoc();
            
            cbListMedoc.DisplayMember = "nomCommercial";
            cbListMedoc.ValueMember = "idMedicament";
            cbListMedoc.DataSource = bsAjoutMed;
            if (Modele.getEtatMedoc() == true)
            {
                NUDQtt.Visible = false;
                lblQtt.Visible = false;
            }
            else
            {
                NUDQtt.Visible = true;
                lblQtt.Visible = true;
            }
        }

        private void bsAjoutMed_CurrentChanged(object sender, EventArgs e)
        {
            lblNomMedocSelect.Text = ((MEDICAMENT)bsAjoutMed.Current).nomCommercial;
            lblFamileMedocSelect.Text = ((MEDICAMENT)bsAjoutMed.Current).FAMILLE.libFamille;
        }

        public MEDICAMENT getCombo()
        {
            return ((MEDICAMENT)bsAjoutMed.Current);
        }

        public int getNbMedoc()
        {
            return (int)NUDQtt.Value;
        }
    }
}
