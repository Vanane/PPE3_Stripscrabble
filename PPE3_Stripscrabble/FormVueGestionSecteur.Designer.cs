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
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomS
            // 
            this.textBoxNomS.Location = new System.Drawing.Point(148, 57);
            this.textBoxNomS.Name = "textBoxNomS";
            this.textBoxNomS.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomS.TabIndex = 0;
            // 
            // textBoxIdSecteur
            // 
            this.textBoxIdSecteur.Location = new System.Drawing.Point(148, 17);
            this.textBoxIdSecteur.Name = "textBoxIdSecteur";
            this.textBoxIdSecteur.ReadOnly = true;
            this.textBoxIdSecteur.Size = new System.Drawing.Size(120, 20);
            this.textBoxIdSecteur.TabIndex = 2;
            // 
            // lblIdS
            // 
            this.lblIdS.AutoSize = true;
            this.lblIdS.Location = new System.Drawing.Point(12, 20);
            this.lblIdS.Name = "lblIdS";
            this.lblIdS.Size = new System.Drawing.Size(64, 13);
            this.lblIdS.TabIndex = 3;
            this.lblIdS.Text = "ID Secteur :";
            // 
            // lblNomS
            // 
            this.lblNomS.AutoSize = true;
            this.lblNomS.Location = new System.Drawing.Point(12, 60);
            this.lblNomS.Name = "lblNomS";
            this.lblNomS.Size = new System.Drawing.Size(90, 13);
            this.lblNomS.TabIndex = 4;
            this.lblNomS.Text = "Nom du Secteur :";
            // 
            // lblVisiteurS
            // 
            this.lblVisiteurS.AutoSize = true;
            this.lblVisiteurS.Location = new System.Drawing.Point(12, 100);
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
            this.DGVRegions.Location = new System.Drawing.Point(15, 124);
            this.DGVRegions.Name = "DGVRegions";
            this.DGVRegions.Size = new System.Drawing.Size(691, 324);
            this.DGVRegions.TabIndex = 7;
            // 
            // textBoxResp
            // 
            this.textBoxResp.Location = new System.Drawing.Point(148, 97);
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.Size = new System.Drawing.Size(120, 20);
            this.textBoxResp.TabIndex = 8;
            // 
            // FormVueGestionSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 460);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.DGVRegions);
            this.Controls.Add(this.lblVisiteurS);
            this.Controls.Add(this.lblNomS);
            this.Controls.Add(this.lblIdS);
            this.Controls.Add(this.textBoxIdSecteur);
            this.Controls.Add(this.textBoxNomS);
            this.Name = "FormVueGestionSecteur";
            this.Text = "FormVueGestionSecteur";
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
    }
}