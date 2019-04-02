namespace PPE3_Stripscrabble
{
    partial class FormVueModifRegion
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
            this.comboBoxRegions = new System.Windows.Forms.ComboBox();
            this.labelSelec = new System.Windows.Forms.Label();
            this.labelVisit = new System.Windows.Forms.Label();
            this.comboBoxVisiteurs = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Location = new System.Drawing.Point(208, 12);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegions.TabIndex = 2;
            // 
            // labelSelec
            // 
            this.labelSelec.AutoSize = true;
            this.labelSelec.Location = new System.Drawing.Point(75, 15);
            this.labelSelec.Name = "labelSelec";
            this.labelSelec.Size = new System.Drawing.Size(127, 13);
            this.labelSelec.TabIndex = 3;
            this.labelSelec.Text = "Sélectionnez une région :";
            // 
            // labelVisit
            // 
            this.labelVisit.AutoSize = true;
            this.labelVisit.Location = new System.Drawing.Point(12, 55);
            this.labelVisit.Name = "labelVisit";
            this.labelVisit.Size = new System.Drawing.Size(190, 13);
            this.labelVisit.TabIndex = 4;
            this.labelVisit.Text = "Sélectionnez le nouveau responsable :";
            // 
            // comboBoxVisiteurs
            // 
            this.comboBoxVisiteurs.FormattingEnabled = true;
            this.comboBoxVisiteurs.Location = new System.Drawing.Point(208, 52);
            this.comboBoxVisiteurs.Name = "comboBoxVisiteurs";
            this.comboBoxVisiteurs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisiteurs.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(260, 160);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.Location = new System.Drawing.Point(179, 160);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormVueModifRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 195);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.comboBoxVisiteurs);
            this.Controls.Add(this.labelVisit);
            this.Controls.Add(this.labelSelec);
            this.Controls.Add(this.comboBoxRegions);
            this.Name = "FormVueModifRegion";
            this.Text = "FormVueModifRegion";
            this.Load += new System.EventHandler(this.FormVueModifRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.Label labelSelec;
        private System.Windows.Forms.Label labelVisit;
        private System.Windows.Forms.ComboBox comboBoxVisiteurs;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
    }
}