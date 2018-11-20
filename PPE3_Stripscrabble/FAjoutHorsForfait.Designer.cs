namespace PPE3_Stripscrabble
{
    partial class FAjoutHorsForfait
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
            this.labTitre = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labLib = new System.Windows.Forms.Label();
            this.labMontant = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBoxLib = new System.Windows.Forms.TextBox();
            this.nudMontant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitre
            // 
            this.labTitre.AutoSize = true;
            this.labTitre.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.labTitre.Location = new System.Drawing.Point(104, 26);
            this.labTitre.Name = "labTitre";
            this.labTitre.Size = new System.Drawing.Size(136, 26);
            this.labTitre.TabIndex = 0;
            this.labTitre.Text = "AUTRES FRAIS";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(24, 92);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(33, 15);
            this.labDate.TabIndex = 1;
            this.labDate.Text = "Date";
            // 
            // labLib
            // 
            this.labLib.AutoSize = true;
            this.labLib.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLib.Location = new System.Drawing.Point(24, 150);
            this.labLib.Name = "labLib";
            this.labLib.Size = new System.Drawing.Size(43, 15);
            this.labLib.TabIndex = 2;
            this.labLib.Text = "Libellé";
            // 
            // labMontant
            // 
            this.labMontant.AutoSize = true;
            this.labMontant.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMontant.Location = new System.Drawing.Point(26, 205);
            this.labMontant.Name = "labMontant";
            this.labMontant.Size = new System.Drawing.Size(55, 15);
            this.labMontant.TabIndex = 3;
            this.labMontant.Text = "Montant";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(168, 266);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(87, 266);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(87, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // txtBoxLib
            // 
            this.txtBoxLib.Location = new System.Drawing.Point(87, 144);
            this.txtBoxLib.Name = "txtBoxLib";
            this.txtBoxLib.Size = new System.Drawing.Size(200, 20);
            this.txtBoxLib.TabIndex = 7;
            // 
            // nudMontant
            // 
            this.nudMontant.Location = new System.Drawing.Point(87, 204);
            this.nudMontant.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudMontant.Name = "nudMontant";
            this.nudMontant.Size = new System.Drawing.Size(120, 20);
            this.nudMontant.TabIndex = 8;
            // 
            // FAjoutHorsForfait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 312);
            this.Controls.Add(this.nudMontant);
            this.Controls.Add(this.txtBoxLib);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.labMontant);
            this.Controls.Add(this.labLib);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labTitre);
            this.Name = "FAjoutHorsForfait";
            this.Text = "FAjoutHorsForfait";
            this.Load += new System.EventHandler(this.FAjoutHorsForfait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labLib;
        private System.Windows.Forms.Label labMontant;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtBoxLib;
        private System.Windows.Forms.NumericUpDown nudMontant;
    }
}