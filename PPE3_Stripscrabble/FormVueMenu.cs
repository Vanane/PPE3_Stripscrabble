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
    public partial class FormVueMenu : Form
    {
        public FormVueMenu()
        {
            InitializeComponent();
        }

        private void FormVueMenu_Load(object sender, EventArgs e)
        {
            lblTest.Text = string.Format("Bienvenue sur l'application GSB, {0} {1}", Modele.getPrenom(), Modele.getNom());
        }
    }
}
