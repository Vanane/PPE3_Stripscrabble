namespace PPE3_Stripscrabble
{
    partial class FormVueGestionSecteur
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
            this.textBoxNomS = new System.Windows.Forms.TextBox();
            this.textBoxIdSecteur = new System.Windows.Forms.TextBox();
            this.lblIdS = new System.Windows.Forms.Label();
            this.lblNomS = new System.Windows.Forms.Label();
            this.lblVisiteurS = new System.Windows.Forms.Label();
            this.DGVRegions = new System.Windows.Forms.DataGridView();
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.lblChamps = new System.Windows.Forms.Label();
            this.btnModifRegion = new System.Windows.Forms.Button();
            this.lblTexte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomS
            // 
            this.textBoxNomS.Location = new System.Drawing.Point(148, 46);
            this.textBoxNomS.Name = "textBoxNomS";
            this.textBoxNomS.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomS.TabIndex = 0;
            // 
            // textBoxIdSecteur
            // 
            this.textBoxIdSecteur.Location = new System.Drawing.Point(148, 6);
            this.textBoxIdSecteur.Name = "textBoxIdSecteur";
            this.textBoxIdSecteur.ReadOnly = true;
            this.textBoxIdSecteur.Size = new System.Drawing.Size(120, 20);
            this.textBoxIdSecteur.TabIndex = 2;
            // 
            // lblIdS
            // 
            this.lblIdS.AutoSize = true;
            this.lblIdS.Location = new System.Drawing.Point(12, 9);
            this.lblIdS.Name = "lblIdS";
            this.lblIdS.Size = new System.Drawing.Size(64, 13);
            this.lblIdS.TabIndex = 3;
            this.lblIdS.Text = "ID Secteur :";
            // 
            // lblNomS
            // 
            this.lblNomS.AutoSize = true;
            this.lblNomS.Location = new System.Drawing.Point(12, 49);
            this.lblNomS.Name = "lblNomS";
            this.lblNomS.Size = new System.Drawing.Size(97, 13);
            this.lblNomS.TabIndex = 4;
            this.lblNomS.Text = "Nom du Secteur : *";
            // 
            // lblVisiteurS
            // 
            this.lblVisiteurS.AutoSize = true;
            this.lblVisiteurS.Location = new System.Drawing.Point(12, 89);
            this.lblVisiteurS.Name = "lblVisiteurS";
            this.lblVisiteurS.Size = new System.Drawing.Size(130, 13);
            this.lblVisiteurS.TabIndex = 5;
            this.lblVisiteurS.Text = "Responsable du Secteur :";
            // 
            // DGVRegions
            // 
            this.DGVRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegions.Location = new System.Drawing.Point(12, 164);
            this.DGVRegions.Name = "DGVRegions";
            this.DGVRegions.Size = new System.Drawing.Size(637, 283);
            this.DGVRegions.TabIndex = 7;
            this.DGVRegions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRegions_CellClick);
            // 
            // textBoxResp
            // 
            this.textBoxResp.Location = new System.Drawing.Point(148, 86);
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.ReadOnly = true;
            this.textBoxResp.Size = new System.Drawing.Size(120, 20);
            this.textBoxResp.TabIndex = 8;
            // 
            // lblChamps
            // 
            this.lblChamps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChamps.AutoSize = true;
            this.lblChamps.Location = new System.Drawing.Point(404, 450);
            this.lblChamps.Name = "lblChamps";
            this.lblChamps.Size = new System.Drawing.Size(245, 13);
            this.lblChamps.TabIndex = 9;
            this.lblChamps.Text = "*Tous les champs marqués d\'un * sont modifiables.";
            // 
            // btnModifRegion
            // 
            this.btnModifRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifRegion.Location = new System.Drawing.Point(527, 86);
            this.btnModifRegion.Name = "btnModifRegion";
            this.btnModifRegion.Size = new System.Drawing.Size(122, 24);
            this.btnModifRegion.TabIndex = 10;
            this.btnModifRegion.Text = "Modifier une Région";
            this.btnModifRegion.UseVisualStyleBackColor = true;
            this.btnModifRegion.Click += new System.EventHandler(this.btnModifRegion_Click);
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Location = new System.Drawing.Point(12, 148);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(492, 13);
            this.lblTexte.TabIndex = 11;
            this.lblTexte.Text = "Vous pouvez consulter les informations d\'une région en cliquant sur la ligne corr" +
    "espondante ci-dessous.";
            // 
            // FormVueGestionSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 472);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.btnModifRegion);
            this.Controls.Add(this.lblChamps);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.DGVRegions);
            this.Controls.Add(this.lblVisiteurS);
            this.Controls.Add(this.lblNomS);
            this.Controls.Add(this.lblIdS);
            this.Controls.Add(this.textBoxIdSecteur);
            this.Controls.Add(this.textBoxNomS);
            this.Name = "FormVueGestionSecteur";
            this.Load += new System.EventHandler(this.FormVueGestionSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomS;
        private System.Windows.Forms.TextBox textBoxIdSecteur;
        private System.Windows.Forms.Label lblIdS;
        private System.Windows.Forms.Label lblNomS;
        private System.Windows.Forms.Label lblVisiteurS;
        private System.Windows.Forms.DataGridView DGVRegions;
        private System.Windows.Forms.TextBox textBoxResp;
        private System.Windows.Forms.Label lblChamps;
        private System.Windows.Forms.Button btnModifRegion;
        private System.Windows.Forms.Label lblTexte;
    }
}