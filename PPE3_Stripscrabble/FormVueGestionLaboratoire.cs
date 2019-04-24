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
    public partial class FormVueGestionLaboratoire : Form
    {
        private Laboratoire Labo;

        public FormVueGestionLaboratoire()
        {
            InitializeComponent();
        }

        public FormVueGestionLaboratoire(Laboratoire l)
        {
            InitializeComponent();
            Labo = l;
        }

        private void FormVueGestionLaboratoire_Load(object sender, EventArgs e)
        {
            DGVVisiteurs.DataSource = Modele.LesVisiteurs().Where(x => x.idLabo == Labo.idLabo).ToList();
            textBoxIdLabo.Text = Labo.idLabo.ToString();
            textBoxNomLabo.Text = Labo.nomLabo;
            textBoxResp.Text = Labo.Directeur.NomComplet;
            textBoxResp.ReadOnly = true;
        }
    }
}
