namespace PPE3_Stripscrabble
{
    partial class FormVueMenuUtilisateur
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
            this.lblTexte = new System.Windows.Forms.Label();
            this.ToolStripInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFiltrer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.secteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTexte.Location = new System.Drawing.Point(15, 36);
            this.lblTexte.Margin = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(20, 17);
            this.lblTexte.TabIndex = 1;
            this.lblTexte.Text = "...";
            // 
            // ToolStripInfos
            // 
            this.ToolStripInfos.Name = "ToolStripInfos";
            this.ToolStripInfos.Size = new System.Drawing.Size(154, 20);
            this.ToolStripInfos.Text = "Modifier ses informations";
            this.ToolStripInfos.Click += new System.EventHandler(this.ToolStripInfos_Click);
            // 
            // ToolStripFiltrer
            // 
            this.ToolStripFiltrer.Name = "ToolStripFiltrer";
            this.ToolStripFiltrer.Size = new System.Drawing.Size(117, 20);
            this.ToolStripFiltrer.Text = "Voir les utilisateurs";
            this.ToolStripFiltrer.Click += new System.EventHandler(this.ToolStripFiltrer_Click);
            // 
            // ToolStripGerer
            // 
            this.ToolStripGerer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secteurToolStripMenuItem,
            this.regionToolStripMenuItem,
            this.laboratoireToolStripMenuItem});
            this.ToolStripGerer.Name = "ToolStripGerer";
            this.ToolStripGerer.Size = new System.Drawing.Size(59, 20);
            this.ToolStripGerer.Text = "Gestion";
            // 
            // secteurToolStripMenuItem
            // 
            this.secteurToolStripMenuItem.Name = "secteurToolStripMenuItem";
            this.secteurToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.secteurToolStripMenuItem.Text = "Secteur";
            this.secteurToolStripMenuItem.Click += new System.EventHandler(this.secteurToolStripMenuItem_Click);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.regionToolStripMenuItem.Text = "Région";
            this.regionToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // laboratoireToolStripMenuItem
            // 
            this.laboratoireToolStripMenuItem.Name = "laboratoireToolStripMenuItem";
            this.laboratoireToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.laboratoireToolStripMenuItem.Text = "Laboratoire";
            this.laboratoireToolStripMenuItem.Click += new System.EventHandler(this.laboratoireToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripInfos,
            this.ToolStripFiltrer,
            this.ToolStripGerer});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(771, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // FormVueMenuUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 390);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormVueMenuUtilisateur";
            this.Text = "Menu Utilisateur";
            this.Load += new System.EventHandler(this.FormVueMenuUtilisateur_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.ToolStripMenuItem ToolStripInfos;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFiltrer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripGerer;
        private System.Windows.Forms.ToolStripMenuItem secteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoireToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}