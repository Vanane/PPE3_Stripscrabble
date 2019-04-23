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
    public partial class FormVueGestionRegion : Form
    {
        private Region LaRegion;
        private FormVueInfoVisiteur FVIV;
        private bool VisiteurEstResponsable;


        public FormVueGestionRegion()
        {
            InitializeComponent();
        }

        public FormVueGestionRegion(Region r, bool resp)
        {
            InitializeComponent();
            LaRegion = r;
            VisiteurEstResponsable = resp;
        }

        private void FormVueInfoRegion_Load(object sender, EventArgs e)
        {
            this.Text = "Informations sur la région " + LaRegion.libRegion;

            textBoxIdRegion.Text = LaRegion.idRegion.ToString();
            textBoxNomRegion.Text = LaRegion.libRegion;
            comboBoxVisiteurs.ValueMember = "idVisiteur";
            comboBoxVisiteurs.DisplayMember = "NomComplet";
            comboBoxVisiteurs.DataSource = Modele.LesVisiteurs();
            comboBoxVisiteurs.SelectedItem = LaRegion.VisiteurResp;

            if (VisiteurEstResponsable)
            {
                comboBoxVisiteurs.Enabled = false;

            }

            DGVVisiteurs.DataSource = LaRegion.Visiteurs.Select(x => new {ID = x.idVisiteur, Nom = x.nom, Prenom = x.prenom, Ville = x.cp + " " + x.ville}).ToList();
            FVIV = new FormVueInfoVisiteur();
        }

        private void btnModifRegion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir changer ces informations ?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                LaRegion.libRegion = textBoxNomRegion.Text;
                Modele.ChangeRespRegion(LaRegion, (Visiteur)comboBoxVisiteurs.SelectedItem);
                MessageBox.Show("Informations modifiées !");
            }
        }

        private void DGVVisiteurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FVIV.Dispose();
            FVIV = new FormVueInfoVisiteur(Modele.VisiteurParSonId((string)DGVVisiteurs[0, e.RowIndex].Value));
            FVIV.Show();
        }
    }
}
