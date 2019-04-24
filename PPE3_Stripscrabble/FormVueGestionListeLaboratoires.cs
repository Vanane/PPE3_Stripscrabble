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
    public partial class FormVueGestionListeLaboratoires : Form
    {
        private FormVueGestionLaboratoire FVGL;
        public FormVueGestionListeLaboratoires()
        {
            InitializeComponent();
        }

        private void FormVueGestionListeLaboratoires_Load(object sender, EventArgs e)
        {
            FVGL = new FormVueGestionLaboratoire();
            Console.WriteLine(Modele.visiteurConnecte.LaboratoireResp.idLabo);
        }

        private void DGVLabos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FVGL.Dispose();
                FVGL = new FormVueGestionLaboratoire(Modele.LaboratoireParSonId((int)DGVLabos[0, e.RowIndex].Value));
                FVGL.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine((int)DGVLabos[0, e.RowIndex].Value);
                MessageBox.Show("Veuillez choisir une ligne valide !", "Erreur");
            }
        }

    }
}
