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
        private FormVueModifRegion FVMR;


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
            DGVRegions.DataSource = Modele.RegionsParSecteur(Modele.visiteurConnecte.Secteur.First()).Select(x => new { ID = x.idRegion, Nom = x.libRegion, Responsable = x.VisiteurResp.prenom + " " + x.VisiteurResp.nom}).ToList();
            FVMR = new FormVueModifRegion(Modele.visiteurConnecte.Secteur.First());
            ready = true;
        }

        private void btnModifRegion_Click(object sender, EventArgs e)
        {
            FVMR.Dispose();
            FVMR = new FormVueModifRegion(Modele.visiteurConnecte.Secteur.First());
            FVMR.Show();
        }

        private void DGVRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(DGVRegions[0,e.RowIndex].Value);
        }
    }
}
