namespace PPE3_Stripscrabble
{
    partial class FormVueInfoVisiteur
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
            this.DGVRegions = new System.Windows.Forms.DataGridView();
            this.lblNomV = new System.Windows.Forms.Label();
            this.lblPrenomV = new System.Windows.Forms.Label();
            this.lblIdV = new System.Windows.Forms.Label();
            this.textBoxIdV = new System.Windows.Forms.TextBox();
            this.textBoxPrenomV = new System.Windows.Forms.TextBox();
            this.textBoxNomV = new System.Windows.Forms.TextBox();
            this.lblTitreDGV = new System.Windows.Forms.Label();
            this.btnAjoutSuppr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRegions
            // 
            this.DGVRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegions.Location = new System.Drawing.Point(12, 148);
            this.DGVRegions.Name = "DGVRegions";
            this.DGVRegions.Size = new System.Drawing.Size(637, 283);
            this.DGVRegions.TabIndex = 5;
            // 
            // lblNomV
            // 
            this.lblNomV.AutoSize = true;
            this.lblNomV.Location = new System.Drawing.Point(26, 55);
            this.lblNomV.Name = "lblNomV";
            this.lblNomV.Size = new System.Drawing.Size(72, 13);
            this.lblNomV.TabIndex = 6;
            this.lblNomV.Text = "Nom Visiteur :";
            // 
            // lblPrenomV
            // 
            this.lblPrenomV.AutoSize = true;
            this.lblPrenomV.Location = new System.Drawing.Point(12, 95);
            this.lblPrenomV.Name = "lblPrenomV";
            this.lblPrenomV.Size = new System.Drawing.Size(86, 13);
            this.lblPrenomV.TabIndex = 7;
            this.lblPrenomV.Text = "Prenom Visiteur :";
            // 
            // lblIdV
            // 
            this.lblIdV.AutoSize = true;
            this.lblIdV.Location = new System.Drawing.Point(37, 15);
            this.lblIdV.Name = "lblIdV";
            this.lblIdV.Size = new System.Drawing.Size(61, 13);
            this.lblIdV.TabIndex = 8;
            this.lblIdV.Text = "ID Visiteur :";
            // 
            // textBoxIdV
            // 
            this.textBoxIdV.Location = new System.Drawing.Point(113, 12);
            this.textBoxIdV.Name = "textBoxIdV";
            this.textBoxIdV.ReadOnly = true;
            this.textBoxIdV.Size = new System.Drawing.Size(120, 20);
            this.textBoxIdV.TabIndex = 9;
            // 
            // textBoxPrenomV
            // 
            this.textBoxPrenomV.Location = new System.Drawing.Point(113, 92);
            this.textBoxPrenomV.Name = "textBoxPrenomV";
            this.textBoxPrenomV.ReadOnly = true;
            this.textBoxPrenomV.Size = new System.Drawing.Size(120, 20);
            this.textBoxPrenomV.TabIndex = 10;
            // 
            // textBoxNomV
            // 
            this.textBoxNomV.Location = new System.Drawing.Point(113, 52);
            this.textBoxNomV.Name = "textBoxNomV";
            this.textBoxNomV.ReadOnly = true;
            this.textBoxNomV.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomV.TabIndex = 11;
            // 
            // lblTitreDGV
            // 
            this.lblTitreDGV.AutoSize = true;
            this.lblTitreDGV.Location = new System.Drawing.Point(9, 132);
            this.lblTitreDGV.Name = "lblTitreDGV";
            this.lblTitreDGV.Size = new System.Drawing.Size(16, 13);
            this.lblTitreDGV.TabIndex = 13;
            this.lblTitreDGV.Text = "...";
            // 
            // btnAjoutSuppr
            // 
            this.btnAjoutSuppr.Location = new System.Drawing.Point(447, 437);
            this.btnAjoutSuppr.Name = "btnAjoutSuppr";
            this.btnAjoutSuppr.Size = new System.Drawing.Size(202, 23);
            this.btnAjoutSuppr.TabIndex = 14;
            this.btnAjoutSuppr.Text = "Ajout/Suppression d\'une affectation";
            this.btnAjoutSuppr.UseVisualStyleBackColor = true;
            this.btnAjoutSuppr.Click += new System.EventHandler(this.btnAjoutSuppr_Click);
            // 
            // FormVueInfoVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 472);
            this.Controls.Add(this.btnAjoutSuppr);
            this.Controls.Add(this.lblTitreDGV);
            this.Controls.Add(this.textBoxNomV);
            this.Controls.Add(this.textBoxPrenomV);
            this.Controls.Add(this.textBoxIdV);
            this.Controls.Add(this.lblIdV);
            this.Controls.Add(this.lblPrenomV);
            this.Controls.Add(this.lblNomV);
            this.Controls.Add(this.DGVRegions);
            this.Name = "FormVueInfoVisiteur";
            this.Load += new System.EventHandler(this.FormVueInfoVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRegions;
        private System.Windows.Forms.Label lblNomV;
        private System.Windows.Forms.Label lblPrenomV;
        private System.Windows.Forms.Label lblIdV;
        private System.Windows.Forms.TextBox textBoxIdV;
        private System.Windows.Forms.TextBox textBoxPrenomV;
        private System.Windows.Forms.TextBox textBoxNomV;
        private System.Windows.Forms.Label lblTitreDGV;
        private System.Windows.Forms.Button btnAjoutSuppr;
    }
}