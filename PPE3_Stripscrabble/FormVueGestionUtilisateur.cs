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
    public partial class FormVueGestionUtilisateur : Form
    {
        bool readOnlyInfo, readOnlyMdp;

        public FormVueGestionUtilisateur()
        {
            InitializeComponent();
        }

        private void FormVueGestionUtilisateur_Load(object sender, EventArgs e)
        {
            textBoxUserNom.Text = Modele.getNom();
            textBoxUserPrenom.Text = Modele.getPrenom();
            textBoxUserRue.Text = Modele.getRue();
            textBoxUserVille.Text = Modele.getVille();
            textBoxUserId.Text = Modele.getIdentifiant();
            textBoxUserMdp.Text = "••••••••";
            readOnlyInfo = true;
        }

        private void buttonModifierInfo_Click(object sender, EventArgs e)
        {
            readOnlyInfo = !readOnlyInfo;
            textBoxUserNom.ReadOnly = readOnlyInfo;
            textBoxUserPrenom.ReadOnly = readOnlyInfo;
            textBoxUserRue.ReadOnly = readOnlyInfo;
            textBoxUserVille.ReadOnly = readOnlyInfo;

            if (readOnlyInfo)
            {
                Modele.modifierInformations(
                    textBoxUserNom.Text,
                    textBoxUserPrenom.Text,
                    textBoxUserRue.Text,
                    textBoxUserVille.Text
                    );
                buttonModifierInfo.Text = "Modifier";
            }
            else
            {
                buttonModifierInfo.Text = "Accepter";
            }
        }

        private void buttonModifierMdp_Click(object sender, EventArgs e)
        {
            FormVueModifMdpConfirmation FVMMC = new FormVueModifMdpConfirmation();
            FVMMC.Show();
        }
    }
}
