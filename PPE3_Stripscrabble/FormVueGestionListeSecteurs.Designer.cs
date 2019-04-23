namespace PPE3_Stripscrabble
{
    partial class FormVueGestionListeSecteurs
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
            this.lblExplic = new System.Windows.Forms.Label();
            this.DGVSecteurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSecteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExplic
            // 
            this.lblExplic.AutoSize = true;
            this.lblExplic.Location = new System.Drawing.Point(12, 9);
            this.lblExplic.Name = "lblExplic";
            this.lblExplic.Size = new System.Drawing.Size(346, 13);
            this.lblExplic.TabIndex = 3;
            this.lblExplic.Text = "Pour modifier une région, cliquez sur la ligne correspondante ci-dessous.";
            // 
            // DGVSecteurs
            // 
            this.DGVSecteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSecteurs.Location = new System.Drawing.Point(12, 25);
            this.DGVSecteurs.Name = "DGVSecteurs";
            this.DGVSecteurs.Size = new System.Drawing.Size(564, 249);
            this.DGVSecteurs.TabIndex = 2;
            this.DGVSecteurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSecteurs_CellClick);
            // 
            // FormVueGestionListeSecteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 286);
            this.Controls.Add(this.lblExplic);
            this.Controls.Add(this.DGVSecteurs);
            this.Name = "FormVueGestionListeSecteurs";
            this.Text = "FormVueGestionListeSecteurs";
            this.Load += new System.EventHandler(this.FormVueGestionListeSecteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSecteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExplic;
        private System.Windows.Forms.DataGridView DGVSecteurs;
    }
}