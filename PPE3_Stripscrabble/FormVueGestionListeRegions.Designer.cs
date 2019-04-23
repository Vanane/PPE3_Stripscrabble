namespace PPE3_Stripscrabble
{
    partial class FormVueGestionListeRegions
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
            this.lblExplic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRegions
            // 
            this.DGVRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegions.Location = new System.Drawing.Point(12, 25);
            this.DGVRegions.Name = "DGVRegions";
            this.DGVRegions.Size = new System.Drawing.Size(564, 249);
            this.DGVRegions.TabIndex = 0;
            this.DGVRegions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRegions_CellClick);
            // 
            // lblExplic
            // 
            this.lblExplic.AutoSize = true;
            this.lblExplic.Location = new System.Drawing.Point(12, 9);
            this.lblExplic.Name = "lblExplic";
            this.lblExplic.Size = new System.Drawing.Size(346, 13);
            this.lblExplic.TabIndex = 1;
            this.lblExplic.Text = "Pour modifier une région, cliquez sur la ligne correspondante ci-dessous.";
            // 
            // FormVueGestionListeRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 286);
            this.Controls.Add(this.lblExplic);
            this.Controls.Add(this.DGVRegions);
            this.Name = "FormVueGestionListeRegions";
            this.Text = "FormVueGestionListeRegions";
            this.Load += new System.EventHandler(this.FormVueGestionListeRegions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRegions;
        private System.Windows.Forms.Label lblExplic;
    }
}