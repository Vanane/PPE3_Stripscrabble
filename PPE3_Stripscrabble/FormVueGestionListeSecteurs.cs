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
    public partial class FormVueGestionListeSecteurs : Form
    {
        private FormVueGestionSecteur FVGS;

        public FormVueGestionListeSecteurs()
        {
            InitializeComponent();
            FVGS = new FormVueGestionSecteur();
        }

        private void FormVueGestionListeSecteurs_Load(object sender, EventArgs e)
        {
            this.Text = "Secteurs sous la responsabilité de " + Modele.visiteurConnecte.NomComplet;
            DGVSecteurs.DataSource = Modele.visiteurConnecte.Secteur.Select(x => new { ID = x.idSecteur, Nom = x.libSecteur}).ToList();
        }

        private void DGVSecteurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FVGS.Dispose();
                FVGS = new FormVueGestionSecteur(Modele.SecteurParSonId((int)DGVSecteurs[0, e.RowIndex].Value));
                FVGS.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine((int)DGVSecteurs[0, e.RowIndex].Value);
                MessageBox.Show("Veuillez choisir une ligne valide !", "Erreur");
            }

        }
    }
}
