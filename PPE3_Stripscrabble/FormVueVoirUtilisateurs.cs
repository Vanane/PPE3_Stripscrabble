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
        private bool ready; //Permet d'empêcher le programme de lancer des requêtes Linq tant qu'il n'est pas connecté.
        private ComboBox LastComboBoxChange; //Permet de savoir quel combobox a été changé en dernier, pour les coordonnées à afficher.
        private FormVueCoordonneesUtilisateur FVCU;


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

            //On affecte à la variable un comboBox choisi arbitrairement afin d'éviter
            //que la variable soit nulle et provoque de potentielles erreurs.
            FVCU = new FormVueCoordonneesUtilisateur();
            LastComboBoxChange = comboBoxSecteur;
            ready = true;
        }


        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
            {
                DGVVisiteurs.DataSource = Modele.VisiteursParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue))
                    .Select(x => new { x.idVisiteur, x.nom, x.prenom, x.cp, x.ville, x.dateEmbauche, x.actif }).ToList();

                lblRespId.Text = Modele.ResponsableParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue)).idVisiteur;
                lblRespPrenom.Text = Modele.ResponsableParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue)).nom.ToUpper() + " " +
                                     Modele.ResponsableParRegion(Convert.ToInt32(comboBoxRegion.SelectedValue)).prenom;

                LastComboBoxChange = comboBoxRegion;
            }
        }

        private void comboBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
            {
                DGVVisiteurs.DataSource = Modele.VisiteursParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue))
                    .Select(x => new { x.idVisiteur, x.nom, x.prenom, x.cp, x.ville, x.dateEmbauche, x.actif }).ToList();

                lblRespId.Text = Modele.ResponsableParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue)).idVisiteur;
                lblRespPrenom.Text = Modele.ResponsableParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue)).nom.ToUpper() + " " +
                                     Modele.ResponsableParSecteur(Convert.ToInt32(comboBoxSecteur.SelectedValue)).prenom;
                LastComboBoxChange = comboBoxSecteur;
            }
        }

        private void btnCoordonnees_Click(object sender, EventArgs e)
        {
            FVCU.Dispose();
            FVCU = new FormVueCoordonneesUtilisateur(LastComboBoxChange.SelectedItem);
            FVCU.Show();
        }
    }
}
