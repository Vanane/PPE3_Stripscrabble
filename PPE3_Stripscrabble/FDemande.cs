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
    public partial class FDemande : Form
    {
        bool Clique;

        public FDemande()
        {
            InitializeComponent();
        }

        private void FDemande_Load(object sender, EventArgs e)
        {
            //Recupere les données de l'utilisateur au chargement de la page
            string[] moisDeLAnnee = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre "};
            labMatricule.Text = Modele.getIdVisiteur();
            labNom.Text = Modele.getNom();
            labPrenom.Text = Modele.getPrenom();
            labDate.Text = moisDeLAnnee[Modele.DateduMois]; //concatener avec l'année
            Clique = false;



            if (cBHF.Checked == true)
            {
                dgvHF.Visible = true;
            } else
            {
                dgvHF.Visible = false;
            }
            // Mettre txtBoxValue au chargement de la page ne va rien afficher vu que les valeurs sont initialement vide
            // Si les valeurs change alors txtBox prends la valeur de ...
            
              //  txtBoxTotalNuit.Text = Convert.ToString(nudMontantUnitNuit.Value * numericUpDownQteNuit.Value);
              //  txtBoxTotalRepas.Text = Convert.ToString(nudMontantUnitRepas.Value * numericUpDownQteRepas.Value);
              //  txtBoxTotalVehicule.Text = Convert.ToString(nudMontantUnitVehicule.Value * numericUpDownQteVehicule.Value);
            
        }

        private void MontantUnitNuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void butAjoutHF_Click(object sender, EventArgs e)
        {
            FAjoutHorsForfait Ajout = new FAjoutHorsForfait();
            Ajout.Show();

            Clique = true;
        }

        private void cBHF_CheckedChanged(object sender, EventArgs e)
        {
            if(cBHF.Checked == true)
            {
                labDateFrais.Visible = true;
                lablib.Visible = true;
                labMontantHF.Visible = true;

                dgvHF.Visible = true;
                butAjoutHF.Visible = true;
                butAjoutLigne.Visible = true;
            }
        }

        private void butAjoutLigne_Click(object sender, EventArgs e)
        {
            if (Clique == true)
            {
                DateTime DateHF;
                string libHF;
                double montantHF;

                DateHF = Modele.DateHF;
                libHF = Modele.LibelleHF;
                montantHF = Modele.MontantHF;

                dgvHF.Rows.Add(DateHF, libHF, montantHF);

                Clique = false;
            }

            

        }

        private void numericUpDownQteNuit_ValueChanged(object sender, EventArgs e)
        {
            txtBoxTotalNuit.Text = Convert.ToString(nudMontantUnitNuit.Value * numericUpDownQteNuit.Value);
        }

        private void nudMontantUnitNuit_ValueChanged(object sender, EventArgs e)
        {
            txtBoxTotalNuit.Text = Convert.ToString(nudMontantUnitNuit.Value * numericUpDownQteNuit.Value);

        }

        private void numericUpDownQteRepas_ValueChanged(object sender, EventArgs e)
        {
            txtBoxTotalRepas.Text = Convert.ToString(nudMontantUnitRepas.Value * numericUpDownQteRepas.Value);
        }

        private void nudMontantUnitRepas_ValueChanged(object sender, EventArgs e)
        {
            txtBoxTotalRepas.Text = Convert.ToString(nudMontantUnitRepas.Value * numericUpDownQteRepas.Value);
        }

        private void numericUpDownQteVehicule_ValueChanged(object sender, EventArgs e)
        {
            txtBoxTotalVehicule.Text = Convert.ToString(nudMontantUnitVehicule.Value * numericUpDownQteVehicule.Value);
        }

        private void nudMontantUnitVehicule_ValueChanged(object sender, EventArgs e)
        {
            txtBoxTotalVehicule.Text = Convert.ToString(nudMontantUnitVehicule.Value * numericUpDownQteVehicule.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Test() == false)
            {
                MessageBox.Show(" Veuillez remplir au moins un champs QUANTITE et un champs MONTANT !");
            }
            else
            {
                this.Close();
            }
        }
        private bool Test()
        {
            bool remplie;
            if (Convert.ToDecimal(numericUpDownQteNuit.Value) != 0 && Convert.ToDecimal(nudMontantUnitNuit.Value) != 0 || Convert.ToDecimal(numericUpDownQteRepas.Value) != 0 && Convert.ToDecimal(nudMontantUnitRepas.Value) != 0 || Convert.ToDecimal(numericUpDownQteVehicule.Value) != 0 && Convert.ToDecimal(nudMontantUnitVehicule.Value) != 0)
            {
                remplie = true;
            }
            else
            {
                remplie = false;

            }
            return remplie;
        }
    }
}






