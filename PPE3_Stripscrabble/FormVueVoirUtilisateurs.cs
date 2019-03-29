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
    public partial class FormVueVoirUtilisateurs : Form
    {
        private bool ready;

        public FormVueVoirUtilisateurs()
        {
            InitializeComponent();
            ready = false;
        }

        private void FormVueVoirUtilisateur_Load(object sender, EventArgs e)
        {
            comboBoxSecteur.ValueMember = "idSecteur";
            comboBoxSecteur.DisplayMember = "libSecteur";
            comboBoxSecteur.DataSource = Modele.lesSecteurs();
            comboBoxRegion.ValueMember = "idregion";
            comboBoxRegion.DisplayMember = "libRegion";
            comboBoxRegion.DataSource = Modele.lesRegions();
            DGVVisiteurs.DataSource = Modele.VisiteursParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue))
                .Select(x => new { x.idVisiteur, x.nom, x.prenom, x.cp, x.ville, x.dateEmbauche, x.actif}).ToList();
            ready = true;
        }


        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
                DGVVisiteurs.DataSource = Modele.VisiteursParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue))
                    .Select(x => new { x.idVisiteur, x.nom, x.prenom, x.cp, x.ville, x.dateEmbauche, x.actif }).ToList();

            lblRespId.Text = Modele.ResponsableParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue)).idVisiteur;
            lblRespPrenom.Text = Modele.ResponsableParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue)).nom.ToUpper() + " " +
                                 Modele.ResponsableParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue)).prenom;
        }

        private void comboBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
                DGVVisiteurs.DataSource = Modele.VisiteursParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue))
                    .Select(x => new { x.idVisiteur, x.nom, x.prenom, x.cp, x.ville, x.dateEmbauche, x.actif }).ToList();

            lblRespId.Text = Modele.ResponsableParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue)).idVisiteur;
            lblRespPrenom.Text = Modele.ResponsableParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue)).nom.ToUpper() + " " +
                                 Modele.ResponsableParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue)).prenom;

        }

    }
}
