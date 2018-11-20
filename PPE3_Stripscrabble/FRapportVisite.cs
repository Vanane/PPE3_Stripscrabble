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
    public partial class FRapportVisite : Form
    {
        List<MEDECIN> lesMedecins;
        List<MOTIF> lesMotifs;

        public FRapportVisite()
        {
            InitializeComponent();
        }

        private void FRapportVisite_Load(object sender, EventArgs e)
        {
            lesMedecins = new List<MEDECIN>();
            lesMotifs = new List<MOTIF>();
            foreach(MEDECIN m in Modele.listMedecin())
            {
                cbBoxMed.Items.Add(m.nom);
                this.lesMedecins.Add(m);
            }
            foreach(MOTIF m in Modele.listMotif())
            {
                cbBoxMotif.Items.Add(m.libMotif);
                this.lesMotifs.Add(m);
            }
        }

        private void cbBoxMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnomMedSelec.Text = lesMedecins[cbBoxMed.SelectedIndex].nom;
            lblPrenomMedSelect.Text = lesMedecins[cbBoxMed.SelectedIndex].prenom;
        }

        private void btnAjoutMedocPresent_Click(object sender, EventArgs e)
        {
            Modele.setEtatMedoc(true);
            FAjoutMedicament FAjoutMed = new FAjoutMedicament();
            FAjoutMed.Show();
        }

        private void btnAjoutMedocEchant_Click(object sender, EventArgs e)
        {
            Modele.setEtatMedoc(false);
            FAjoutMedicament FAjoutMed = new FAjoutMedicament();
            FAjoutMed.Show();
        }

        private void btnAnnulerRapport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
