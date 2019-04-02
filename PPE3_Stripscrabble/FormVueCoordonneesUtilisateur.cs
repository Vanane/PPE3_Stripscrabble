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
    public partial class FormVueCoordonneesUtilisateur : Form
    {
       private object leContact;
        public FormVueCoordonneesUtilisateur()
        {
            InitializeComponent();
        }

        public FormVueCoordonneesUtilisateur(object o)
        {
            InitializeComponent();
            leContact = o;
        }

        private void FormVueCoordonneesUtilisateur_Load(object sender, EventArgs e)
        {
            if (leContact is Secteur)
            {
                Secteur s = (Secteur)leContact;
                lblInfos.Text = s.Visiteur.ToString();
            }
            else
            {
                if (leContact is Region)
                {
                    Region r = (Region)leContact;
                    lblInfos.Text = r.VisiteurResp.ToString();
                }
            }

            this.Width = lblInfos.Width + 30;

        }
    }
}
