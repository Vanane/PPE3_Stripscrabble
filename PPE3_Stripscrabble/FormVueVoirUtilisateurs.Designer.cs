namespace PPE3_Stripscrabble
{
    partial class FormVueVoirUtilisateurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblRespId = new System.Windows.Forms.Label();
            this.lblRespPrenom = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.comboBoxSecteur = new System.Windows.Forms.ComboBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.DGVVisiteurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(468, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID Responsable :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(457, 50);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 13);
            this.lblNom.TabIndex = 20;
            this.lblNom.Text = "Nom Responsable :";
            // 
            // lblRespId
            // 
            this.lblRespId.AutoSize = true;
            this.lblRespId.Location = new System.Drawing.Point(563, 9);
            this.lblRespId.Name = "lblRespId";
            this.lblRespId.Size = new System.Drawing.Size(76, 13);
            this.lblRespId.TabIndex = 19;
            this.lblRespId.Text = ".......................";
            // 
            // lblRespPrenom
            // 
            this.lblRespPrenom.AutoSize = true;
            this.lblRespPrenom.Location = new System.Drawing.Point(563, 50);
            this.lblRespPrenom.Name = "lblRespPrenom";
            this.lblRespPrenom.Size = new System.Drawing.Size(76, 13);
            this.lblRespPrenom.TabIndex = 18;
            this.lblRespPrenom.Text = ".......................";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(12, 50);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(90, 13);
            this.lblReg.TabIndex = 17;
            this.lblReg.Text = "Filtre par Région :";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(12, 9);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(93, 13);
            this.lblSec.TabIndex = 16;
            this.lblSec.Text = "Filtre par Secteur :";
            // 
            // comboBoxSecteur
            // 
            this.comboBoxSecteur.FormattingEnabled = true;
            this.comboBoxSecteur.Location = new System.Drawing.Point(111, 6);
            this.comboBoxSecteur.Name = "comboBoxSecteur";
            this.comboBoxSecteur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecteur.TabIndex = 15;
            this.comboBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecteur_SelectedIndexChanged);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(111, 47);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegion.TabIndex = 14;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // DGVVisiteurs
            // 
            this.DGVVisiteurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVisiteurs.Location = new System.Drawing.Point(12, 74);
            this.DGVVisiteurs.Name = "DGVVisiteurs";
            this.DGVVisiteurs.Size = new System.Drawing.Size(667, 256);
            this.DGVVisiteurs.TabIndex = 13;
            // 
            // FormVueVoirUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 342);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblRespId);
            this.Controls.Add(this.lblRespPrenom);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.comboBoxSecteur);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.DGVVisiteurs);
            this.Name = "FormVueVoirUtilisateurs";
            this.Text = "Liste des Utilisateurs";
            this.Load += new System.EventHandler(this.FormVueVoirUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblRespId;
        private System.Windows.Forms.Label lblRespPrenom;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.ComboBox comboBoxSecteur;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.DataGridView DGVVisiteurs;
    }
}