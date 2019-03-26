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
        bool ready;
        public FormVueGestionSecteur()
        {
            InitializeComponent();
            ready = false;
        }

        private void FormVueGestionSecteur_Load(object sender, EventArgs e)
        {
            textBoxIdSecteur.Text = Modele.visiteurConnecte.Secteur.First().idSecteur.ToString();
            textBoxNomS.Text = Modele.visiteurConnecte.Secteur.First().libSecteur;
            textBoxResp.Text = Modele.visiteurConnecte.nom + " " + Modele.visiteurConnecte.prenom;
            DGVRegions.DataSource = Modele.RegionsParSecteur(Modele.visiteurConnecte.Secteur.First());
        }
    }
}
