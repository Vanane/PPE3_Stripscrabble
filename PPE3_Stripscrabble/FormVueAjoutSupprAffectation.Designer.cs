namespace PPE3_Stripscrabble
{
    partial class FormVueAjoutSupprAffectation
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
            this.lvlRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Location = new System.Drawing.Point(252, 12);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegions.TabIndex = 1;
            // 
            // lvlRegion
            // 
            this.lvlRegion.AutoSize = true;
            this.lvlRegion.Location = new System.Drawing.Point(12, 15);
            this.lvlRegion.Name = "lvlRegion";
            this.lvlRegion.Size = new System.Drawing.Size(234, 13);
            this.lvlRegion.TabIndex = 2;
            this.lvlRegion.Text = "Choisissez une Région à laquelle ajouter/retirer :";
            // 
            // FormVueAjoutSupprAffectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvlRegion);
            this.Controls.Add(this.comboBoxRegions);
            this.Name = "FormVueAjoutSupprAffectation";
            this.Text = "Ajout/Suppression d\'une affectation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.Label lvlRegion;
    }
}