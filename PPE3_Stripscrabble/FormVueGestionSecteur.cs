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
        private FormVueGestionRegion FVIR;
        private Secteur LeSecteur;


        public FormVueGestionSecteur()
        {
            InitializeComponent();
            ready = false;
        }

        public FormVueGestionSecteur(Secteur s)
        {
            InitializeComponent();
            LeSecteur = s;
            ready = false;
        }

        private void FormVueGestionSecteur_Load(object sender, EventArgs e)
        {
            this.Text = "Gestion du secteur " + LeSecteur.libSecteur;
            textBoxIdSecteur.Text = LeSecteur.idSecteur.ToString();
            textBoxNomS.Text = LeSecteur.libSecteur;
            textBoxResp.Text = Modele.visiteurConnecte.nom + " " + Modele.visiteurConnecte.prenom;
            DGVRegions.DataSource = Modele.RegionsParSecteur(Modele.visiteurConnecte.Secteur.First()).Select(x => new { ID = x.idRegion, Libellé = x.libRegion, Responsable = x.VisiteurResp.NomComplet}).ToList();
            FVIR = new FormVueGestionRegion();
            ready = true;
        }

        private void DGVRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FVIR.Dispose();
                FVIR = new FormVueGestionRegion(Modele.RegionParSonId((int)DGVRegions[0, e.RowIndex].Value), false);
                FVIR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez choisir une ligne valide !", "Erreur");
            }
        }

        private void btnModifSecteur_Click(object sender, EventArgs e)
        {
            LeSecteur.libSecteur = textBoxNomS.Text;
            Modele.Save();
        }
    }
}
