namespace PPE3_Stripscrabble
{
    partial class FAjoutMedicament
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
            this.lblListMedoc = new System.Windows.Forms.Label();
            this.cbListMedoc = new System.Windows.Forms.ComboBox();
            this.lblNomMedoc = new System.Windows.Forms.Label();
            this.lblNomMedocSelect = new System.Windows.Forms.Label();
            this.lblFamileMedoc = new System.Windows.Forms.Label();
            this.lblMedocFamille = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListMedoc
            // 
            this.lblListMedoc.AutoSize = true;
            this.lblListMedoc.Location = new System.Drawing.Point(12, 46);
            this.lblListMedoc.Name = "lblListMedoc";
            this.lblListMedoc.Size = new System.Drawing.Size(123, 13);
            this.lblListMedoc.TabIndex = 0;
            this.lblListMedoc.Text = "Liste des médicaments : ";
            // 
            // cbListMedoc
            // 
            this.cbListMedoc.FormattingEnabled = true;
            this.cbListMedoc.Location = new System.Drawing.Point(141, 43);
            this.cbListMedoc.Name = "cbListMedoc";
            this.cbListMedoc.Size = new System.Drawing.Size(121, 21);
            this.cbListMedoc.TabIndex = 1;
            // 
            // lblNomMedoc
            // 
            this.lblNomMedoc.AutoSize = true;
            this.lblNomMedoc.Location = new System.Drawing.Point(15, 80);
            this.lblNomMedoc.Name = "lblNomMedoc";
            this.lblNomMedoc.Size = new System.Drawing.Size(93, 13);
            this.lblNomMedoc.TabIndex = 2;
            this.lblNomMedoc.Text = "nom Commercial : ";
            // 
            // lblNomMedocSelect
            // 
            this.lblNomMedocSelect.AutoSize = true;
            this.lblNomMedocSelect.Location = new System.Drawing.Point(138, 80);
            this.lblNomMedocSelect.Name = "lblNomMedocSelect";
            this.lblNomMedocSelect.Size = new System.Drawing.Size(92, 13);
            this.lblNomMedocSelect.TabIndex = 3;
            this.lblNomMedocSelect.Text = "NomMedocSelect";
            // 
            // lblFamileMedoc
            // 
            this.lblFamileMedoc.AutoSize = true;
            this.lblFamileMedoc.Location = new System.Drawing.Point(18, 97);
            this.lblFamileMedoc.Name = "lblFamileMedoc";
            this.lblFamileMedoc.Size = new System.Drawing.Size(48, 13);
            this.lblFamileMedoc.TabIndex = 4;
            this.lblFamileMedoc.Text = "Famille : ";
            // 
            // lblMedocFamille
            // 
            this.lblMedocFamille.AutoSize = true;
            this.lblMedocFamille.Location = new System.Drawing.Point(138, 97);
            this.lblMedocFamille.Name = "lblMedocFamille";
            this.lblMedocFamille.Size = new System.Drawing.Size(89, 13);
            this.lblMedocFamille.TabIndex = 5;
            this.lblMedocFamille.Text = "nomFamilleSelect";
            // 
            // FAjoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedocFamille);
            this.Controls.Add(this.lblFamileMedoc);
            this.Controls.Add(this.lblNomMedocSelect);
            this.Controls.Add(this.lblNomMedoc);
            this.Controls.Add(this.cbListMedoc);
            this.Controls.Add(this.lblListMedoc);
            this.Name = "FAjoutMedicament";
            this.Text = "FAjoutMedicament";
            this.Load += new System.EventHandler(this.FAjoutMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListMedoc;
        private System.Windows.Forms.ComboBox cbListMedoc;
        private System.Windows.Forms.Label lblNomMedoc;
        private System.Windows.Forms.Label lblNomMedocSelect;
        private System.Windows.Forms.Label lblFamileMedoc;
        private System.Windows.Forms.Label lblMedocFamille;
    }
}