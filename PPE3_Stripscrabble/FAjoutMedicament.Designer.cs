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
            this.lblFamileMedocSelect = new System.Windows.Forms.Label();
            this.lblQtt = new System.Windows.Forms.Label();
            this.NUDQtt = new System.Windows.Forms.NumericUpDown();
            this.btnValiderAjoutMedoc = new System.Windows.Forms.Button();
            this.btnAnnulerAjoutMedoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQtt)).BeginInit();
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
            this.cbListMedoc.SelectedIndexChanged += new System.EventHandler(this.cbListMedoc_SelectedIndexChanged);
            // 
            // lblNomMedoc
            // 
            this.lblNomMedoc.AutoSize = true;
            this.lblNomMedoc.Location = new System.Drawing.Point(12, 80);
            this.lblNomMedoc.Name = "lblNomMedoc";
            this.lblNomMedoc.Size = new System.Drawing.Size(95, 13);
            this.lblNomMedoc.TabIndex = 2;
            this.lblNomMedoc.Text = "Nom Commercial : ";
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
            this.lblFamileMedoc.Location = new System.Drawing.Point(12, 97);
            this.lblFamileMedoc.Name = "lblFamileMedoc";
            this.lblFamileMedoc.Size = new System.Drawing.Size(48, 13);
            this.lblFamileMedoc.TabIndex = 4;
            this.lblFamileMedoc.Text = "Famille : ";
            // 
            // lblFamileMedocSelect
            // 
            this.lblFamileMedocSelect.AutoSize = true;
            this.lblFamileMedocSelect.Location = new System.Drawing.Point(138, 97);
            this.lblFamileMedocSelect.Name = "lblFamileMedocSelect";
            this.lblFamileMedocSelect.Size = new System.Drawing.Size(91, 13);
            this.lblFamileMedocSelect.TabIndex = 5;
            this.lblFamileMedocSelect.Text = "NomFamilleSelect";
            // 
            // lblQtt
            // 
            this.lblQtt.AutoSize = true;
            this.lblQtt.Location = new System.Drawing.Point(12, 126);
            this.lblQtt.Name = "lblQtt";
            this.lblQtt.Size = new System.Drawing.Size(56, 13);
            this.lblQtt.TabIndex = 6;
            this.lblQtt.Text = "Quantité : ";
            // 
            // NUDQtt
            // 
            this.NUDQtt.Location = new System.Drawing.Point(141, 124);
            this.NUDQtt.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDQtt.Name = "NUDQtt";
            this.NUDQtt.Size = new System.Drawing.Size(88, 20);
            this.NUDQtt.TabIndex = 7;
            // 
            // btnValiderAjoutMedoc
            // 
            this.btnValiderAjoutMedoc.Location = new System.Drawing.Point(12, 161);
            this.btnValiderAjoutMedoc.Name = "btnValiderAjoutMedoc";
            this.btnValiderAjoutMedoc.Size = new System.Drawing.Size(75, 23);
            this.btnValiderAjoutMedoc.TabIndex = 8;
            this.btnValiderAjoutMedoc.Text = "Valider";
            this.btnValiderAjoutMedoc.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerAjoutMedoc
            // 
            this.btnAnnulerAjoutMedoc.Location = new System.Drawing.Point(141, 161);
            this.btnAnnulerAjoutMedoc.Name = "btnAnnulerAjoutMedoc";
            this.btnAnnulerAjoutMedoc.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerAjoutMedoc.TabIndex = 9;
            this.btnAnnulerAjoutMedoc.Text = "Annuler";
            this.btnAnnulerAjoutMedoc.UseVisualStyleBackColor = true;
            this.btnAnnulerAjoutMedoc.Click += new System.EventHandler(this.btnAnnulerAjoutMedoc_Click);
            // 
            // FAjoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 239);
            this.Controls.Add(this.btnAnnulerAjoutMedoc);
            this.Controls.Add(this.btnValiderAjoutMedoc);
            this.Controls.Add(this.NUDQtt);
            this.Controls.Add(this.lblQtt);
            this.Controls.Add(this.lblFamileMedocSelect);
            this.Controls.Add(this.lblFamileMedoc);
            this.Controls.Add(this.lblNomMedocSelect);
            this.Controls.Add(this.lblNomMedoc);
            this.Controls.Add(this.cbListMedoc);
            this.Controls.Add(this.lblListMedoc);
            this.Name = "FAjoutMedicament";
            this.Text = "FAjoutMedicament";
            this.Load += new System.EventHandler(this.FAjoutMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDQtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListMedoc;
        private System.Windows.Forms.ComboBox cbListMedoc;
        private System.Windows.Forms.Label lblNomMedoc;
        private System.Windows.Forms.Label lblNomMedocSelect;
        private System.Windows.Forms.Label lblFamileMedoc;
        private System.Windows.Forms.Label lblFamileMedocSelect;
        private System.Windows.Forms.Label lblQtt;
        private System.Windows.Forms.NumericUpDown NUDQtt;
        private System.Windows.Forms.Button btnValiderAjoutMedoc;
        private System.Windows.Forms.Button btnAnnulerAjoutMedoc;
    }
}