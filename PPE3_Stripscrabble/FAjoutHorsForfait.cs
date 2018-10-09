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
    public partial class FAjoutHorsForfait : Form
    {
        public FAjoutHorsForfait()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Modele.DateHF = dateTimePicker.Value.Date;
            Modele.LibelleHF = txtBoxLib.Text;
            Modele.MontantHF = Decimal.ToDouble(nudMontant.Value);
            Modele.DateduMois = dateTimePicker.Value.Date.Month;

            this.Close();

            //Si le mois est changé alors affiché une erreur + Ajouter une date limite qui est le 20 de mois
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            dateTimePicker.ResetText();
            txtBoxLib.ResetText();
            nudMontant.ResetText();
        }

        private void FAjoutHorsForfait_Load(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Now.AddDays(- DateTime.Now.Day + 1);
        }
    }
}
