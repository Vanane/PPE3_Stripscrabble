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
    public partial class FormVueGestionListeRegions : Form
    {
        private FormVueGestionRegion FVGR;

        public FormVueGestionListeRegions()
        {
            InitializeComponent();
            FVGR = new FormVueGestionRegion();
        }

        private void FormVueGestionListeRegions_Load(object sender, EventArgs e)
        {
            this.Text = "Régions sous la responsabilité de " + Modele.visiteurConnecte.NomComplet;
            DGVRegions.DataSource = Modele.visiteurConnecte.Region.Select(x => new { ID = x.idRegion, Nom = x.libRegion}).ToList();
        }

        private void DGVRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FVGR.Dispose();
                FVGR = new FormVueGestionRegion(Modele.RegionParSonId((int)DGVRegions[0, e.RowIndex].Value), true);
                FVGR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez choisir une ligne valide !", "Erreur");
            }
        }
    }
}
