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
    public partial class FormVueModifMdpConfirmation : Form
    {
        public FormVueModifMdpConfirmation()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (Modele.modifierMDP(textBoxAncien.Text, textBoxNouveau.Text) && (textBoxNouveau.Text == textBoxNouveauConf.Text))
            {
                MessageBox.Show("Votre mot de passe a bien été modifié.", "Validation");
                this.Close();
            }
            else lblErr.Text = "Erreur : l'une des données n'est pas valide.";
                
        }
    }
}
