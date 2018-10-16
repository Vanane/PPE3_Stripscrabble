namespace PPE3_Stripscrabble
{
    partial class FormDemandeRemboursement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dEMANDEDEREMBOURSEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERIFIERUNEDEMANDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTERUNEDEMANDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEMANDEDEREMBOURSEMENTToolStripMenuItem,
            this.vERIFIERUNEDEMANDEToolStripMenuItem,
            this.cONSULTERUNEDEMANDEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dEMANDEDEREMBOURSEMENTToolStripMenuItem
            // 
            this.dEMANDEDEREMBOURSEMENTToolStripMenuItem.Name = "dEMANDEDEREMBOURSEMENTToolStripMenuItem";
            this.dEMANDEDEREMBOURSEMENTToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
            this.dEMANDEDEREMBOURSEMENTToolStripMenuItem.Text = "DEMANDE DE REMBOURSEMENT";
            this.dEMANDEDEREMBOURSEMENTToolStripMenuItem.Click += new System.EventHandler(this.dEMANDEDEREMBOURSEMENTToolStripMenuItem_Click);
            // 
            // vERIFIERUNEDEMANDEToolStripMenuItem
            // 
            this.vERIFIERUNEDEMANDEToolStripMenuItem.Name = "vERIFIERUNEDEMANDEToolStripMenuItem";
            this.vERIFIERUNEDEMANDEToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.vERIFIERUNEDEMANDEToolStripMenuItem.Text = "VERIFIER UNE DEMANDE";
            this.vERIFIERUNEDEMANDEToolStripMenuItem.Click += new System.EventHandler(this.vERIFIERUNEDEMANDEToolStripMenuItem_Click);
            // 
            // cONSULTERUNEDEMANDEToolStripMenuItem
            // 
            this.cONSULTERUNEDEMANDEToolStripMenuItem.Name = "cONSULTERUNEDEMANDEToolStripMenuItem";
            this.cONSULTERUNEDEMANDEToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.cONSULTERUNEDEMANDEToolStripMenuItem.Text = "CONSULTER UNE DEMANDE";
            // 
            // FormDemandeRemboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 190);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDemandeRemboursement";
            this.Text = "FormDemandeRemboursement";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dEMANDEDEREMBOURSEMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERIFIERUNEDEMANDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTERUNEDEMANDEToolStripMenuItem;
    }
}