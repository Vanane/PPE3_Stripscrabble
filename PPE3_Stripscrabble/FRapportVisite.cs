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
            lblAuteurRapportSelect.Text = Modele.getNom() + " " + Modele.getPrenom();

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
            dgvMedocPresent.Columns.Add("id medicament", "id");
            dgvMedocPresent.Columns.Add("nom medicament", "nom");
            dgvMedocPresent.Columns.Add("famille medicament", "famille");

            dgvMedocEchant.Columns.Add("id echantillon", "id");
            dgvMedocEchant.Columns.Add("nom echantillon", "nom");
            dgvMedocEchant.Columns.Add("famille echantillon", "famille");
            dgvMedocEchant.Columns.Add("nombre d'échantillon", "nombre");

            rTxtBoxRapport.MaxLength = 64;
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
            if(FAjoutMed.ShowDialog()==DialogResult.OK)
            {
                MEDICAMENT monMedoc = FAjoutMed.getCombo();
                MessageBox.Show(monMedoc.nomCommercial);

                string[] maLigne = new string[] { monMedoc.idMedicament, monMedoc.nomCommercial, monMedoc.FAMILLE.libFamille };
                dgvMedocPresent.Rows.Add(maLigne);
            }
        }

        private void btnAjoutMedocEchant_Click(object sender, EventArgs e)
        {
            Modele.setEtatMedoc(false);
            FAjoutMedicament FAjoutMed = new FAjoutMedicament();
            if (FAjoutMed.ShowDialog() == DialogResult.OK)
            {
                MEDICAMENT monMedoc = FAjoutMed.getCombo();
                int nbMedoc = FAjoutMed.getNbMedoc();
                MessageBox.Show(monMedoc.nomCommercial + " \n quantité : " + nbMedoc);

                string[] maLigne = new string[] { monMedoc.idMedicament, monMedoc.nomCommercial, monMedoc.FAMILLE.libFamille, nbMedoc.ToString() };
                dgvMedocEchant.Rows.Add(maLigne);
            }
        }

        private void btnAnnulerRapport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRetirMedocPresent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell uneCase in dgvMedocPresent.SelectedCells)
            {
                if (uneCase.Selected)
                    dgvMedocPresent.Rows.RemoveAt(uneCase.RowIndex);
            }
        }

        private void BtnRetirMedocEchant_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell uneCase in dgvMedocEchant.SelectedCells)
            {
                if (uneCase.Selected)
                    dgvMedocEchant.Rows.RemoveAt(uneCase.RowIndex);
            }
        }

        private void BtnValiderRapport_Click(object sender, EventArgs e)
        {
            RAPPORT leRapport = new RAPPORT();
            leRapport.idMedecin = lesMedecins[cbBoxMed.SelectedIndex].idMedecin;
            leRapport.idMotif = lesMotifs[cbBoxMotif.SelectedIndex].idMotif;
            leRapport.bilan = rTxtBoxRapport.Text;
            leRapport.dateRapport = DateTime.Now;
            leRapport.idVisiteur = Modele.getIdVisiteur();
            leRapport.idRapport = Modele.dernierRapport() + 1;
            OFFRIR medocPresent = new OFFRIR();
            medocPresent.idRapport = leRapport.idRapport;
            medocPresent.idMedicament = dgvMedocPresent.Rows[0].Cells[0].Value.ToString();
            medocPresent.quantite = null;
            OFFRIR medocEchant = new OFFRIR();
            medocEchant.idRapport = leRapport.idRapport;
            medocEchant.idMedicament = dgvMedocEchant.Rows[0].Cells[0].Value.ToString();
            medocEchant.quantite = int.Parse(dgvMedocEchant.Rows[0].Cells[3].Value.ToString());
            Modele.AjouteUnRapport(leRapport);
            Modele.AjouteOffrir(medocPresent);
            Modele.AjouteOffrir(medocEchant);
            Modele.Save();
            this.Close();
        }
    }
}
