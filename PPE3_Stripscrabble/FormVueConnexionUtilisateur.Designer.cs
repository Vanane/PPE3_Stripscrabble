namespace PPE3_Stripscrabble
{
    partial class FormVueConnexionUtilisateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMDP = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.btnTestRegion = new System.Windows.Forms.Button();
            this.btnTestLabo = new System.Windows.Forms.Button();
            this.btnTestSecteur = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelMDP.Location = new System.Drawing.Point(86, 230);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(90, 17);
            this.labelMDP.TabIndex = 0;
            this.labelMDP.Text = "Mot de passe :";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelIdentifiant.Location = new System.Drawing.Point(102, 192);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(74, 17);
            this.labelIdentifiant.TabIndex = 1;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(182, 190);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(200, 20);
            this.textBoxIdentifiant.TabIndex = 0;
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(182, 228);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.PasswordChar = '●';
            this.textBoxMDP.Size = new System.Drawing.Size(200, 20);
            this.textBoxMDP.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PPE3_Stripscrabble.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(30, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(424, 169);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonConnexion.Location = new System.Drawing.Point(200, 264);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(100, 30);
            this.buttonConnexion.TabIndex = 2;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // btnTestRegion
            // 
            this.btnTestRegion.Location = new System.Drawing.Point(3, 16);
            this.btnTestRegion.Name = "btnTestRegion";
            this.btnTestRegion.Size = new System.Drawing.Size(96, 23);
            this.btnTestRegion.TabIndex = 5;
            this.btnTestRegion.Text = "jfinck region";
            this.btnTestRegion.UseVisualStyleBackColor = true;
            this.btnTestRegion.Click += new System.EventHandler(this.btnTestRegion_Click);
            // 
            // btnTestLabo
            // 
            this.btnTestLabo.Location = new System.Drawing.Point(3, 74);
            this.btnTestLabo.Name = "btnTestLabo";
            this.btnTestLabo.Size = new System.Drawing.Size(96, 23);
            this.btnTestLabo.TabIndex = 6;
            this.btnTestLabo.Text = "ecadic labo";
            this.btnTestLabo.UseVisualStyleBackColor = true;
            this.btnTestLabo.Click += new System.EventHandler(this.btnTestLabo_Click);
            // 
            // btnTestSecteur
            // 
            this.btnTestSecteur.Location = new System.Drawing.Point(3, 45);
            this.btnTestSecteur.Name = "btnTestSecteur";
            this.btnTestSecteur.Size = new System.Drawing.Size(96, 23);
            this.btnTestSecteur.TabIndex = 7;
            this.btnTestSecteur.Text = "veynde secteur";
            this.btnTestSecteur.UseVisualStyleBackColor = true;
            this.btnTestSecteur.Click += new System.EventHandler(this.btnTestSecteur_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(3, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(105, 13);
            this.lblTest.TabIndex = 8;
            this.lblTest.Text = "!!! Boutons de test !!!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTest);
            this.flowLayoutPanel1.Controls.Add(this.btnTestRegion);
            this.flowLayoutPanel1.Controls.Add(this.btnTestSecteur);
            this.flowLayoutPanel1.Controls.Add(this.btnTestLabo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(372, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(111, 100);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // FormVueConnexionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.labelMDP);
            this.Name = "FormVueConnexionUtilisateur";
            this.Padding = new System.Windows.Forms.Padding(27);
            this.Text = "Se connecter à l\'application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button btnTestRegion;
        private System.Windows.Forms.Button btnTestLabo;
        private System.Windows.Forms.Button btnTestSecteur;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

