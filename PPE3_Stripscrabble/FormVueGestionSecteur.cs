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
    public partial class FormVueGestionSecteur : Form
    {
        private bool ready;
        private FormVueInfoRegion FVIR;


        public FormVueGestionSecteur()
        {
            InitializeComponent();
            ready = false;
        }

        private void FormVueGestionSecteur_Load(object sender, EventArgs e)
        {
            this.Text = "Gestion du secteur " + Modele.visiteurConnecte.Secteur.First().libSecteur.ToString();
            textBoxIdSecteur.Text = Modele.visiteurConnecte.Secteur.First().idSecteur.ToString();
            textBoxNomS.Text = Modele.visiteurConnecte.Secteur.First().libSecteur;
            textBoxResp.Text = Modele.visiteurConnecte.nom + " " + Modele.visiteurConnecte.prenom;
            DGVRegions.DataSource = Modele.RegionsParSecteur(Modele.visiteurConnecte.Secteur.First()).Select(x => new { ID = x.idRegion, Libellé = x.libRegion, Responsable = x.VisiteurResp.NomComplet}).ToList();
            FVIR = new FormVueInfoRegion();
            ready = true;
        }

        private void DGVRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FVIR.Dispose();
            FVIR = new FormVueInfoRegion(Modele.RegionParSonId((int)DGVRegions[0, e.RowIndex].Value));
            FVIR.Show();
        }
    }
}
