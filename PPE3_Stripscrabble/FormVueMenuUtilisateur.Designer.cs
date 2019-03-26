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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.secteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVVisiteurs = new System.Windows.Forms.DataGridView();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxSecteur = new System.Windows.Forms.ComboBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblRespPrenom = new System.Windows.Forms.Label();
            this.lblRespId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripInfos,
            this.ToolStripGerer,
            this.ToolStripQuitter});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(771, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // ToolStripInfos
            // 
            this.ToolStripInfos.Name = "ToolStripInfos";
            this.ToolStripInfos.Size = new System.Drawing.Size(143, 20);
            this.ToolStripInfos.Text = "Informations Utilisateur";
            this.ToolStripInfos.Click += new System.EventHandler(this.ToolStripInfos_Click);
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
            this.secteurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secteurToolStripMenuItem.Text = "Secteur";
            this.secteurToolStripMenuItem.Click += new System.EventHandler(this.secteurToolStripMenuItem_Click);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regionToolStripMenuItem.Text = "Région";
            this.regionToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // laboratoireToolStripMenuItem
            // 
            this.laboratoireToolStripMenuItem.Name = "laboratoireToolStripMenuItem";
            this.laboratoireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.laboratoireToolStripMenuItem.Text = "Laboratoire";
            this.laboratoireToolStripMenuItem.Click += new System.EventHandler(this.laboratoireToolStripMenuItem_Click);
            // 
            // ToolStripQuitter
            // 
            this.ToolStripQuitter.Name = "ToolStripQuitter";
            this.ToolStripQuitter.Size = new System.Drawing.Size(56, 20);
            this.ToolStripQuitter.Text = "Quitter";
            this.ToolStripQuitter.Click += new System.EventHandler(this.ToolStripQuitter_Click);
            // 
            // DGVVisiteurs
            // 
            this.DGVVisiteurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVisiteurs.Location = new System.Drawing.Point(12, 133);
            this.DGVVisiteurs.Name = "DGVVisiteurs";
            this.DGVVisiteurs.Size = new System.Drawing.Size(747, 245);
            this.DGVVisiteurs.TabIndex = 1;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(108, 88);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegion.TabIndex = 3;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // comboBoxSecteur
            // 
            this.comboBoxSecteur.FormattingEnabled = true;
            this.comboBoxSecteur.Location = new System.Drawing.Point(108, 47);
            this.comboBoxSecteur.Name = "comboBoxSecteur";
            this.comboBoxSecteur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecteur.TabIndex = 4;
            this.comboBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecteur_SelectedIndexChanged);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(9, 50);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(93, 13);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "Filtre par Secteur :";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(9, 91);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(90, 13);
            this.lblReg.TabIndex = 6;
            this.lblReg.Text = "Filtre par Région :";
            // 
            // lblRespPrenom
            // 
            this.lblRespPrenom.AutoSize = true;
            this.lblRespPrenom.Location = new System.Drawing.Point(560, 91);
            this.lblRespPrenom.Name = "lblRespPrenom";
            this.lblRespPrenom.Size = new System.Drawing.Size(76, 13);
            this.lblRespPrenom.TabIndex = 7;
            this.lblRespPrenom.Text = ".......................";
            // 
            // lblRespId
            // 
            this.lblRespId.AutoSize = true;
            this.lblRespId.Location = new System.Drawing.Point(560, 50);
            this.lblRespId.Name = "lblRespId";
            this.lblRespId.Size = new System.Drawing.Size(76, 13);
            this.lblRespId.TabIndex = 9;
            this.lblRespId.Text = ".......................";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(454, 91);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 13);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom Responsable :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(465, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID Responsable :";
            // 
            // FormVueMenuUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 390);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblRespId);
            this.Controls.Add(this.lblRespPrenom);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.comboBoxSecteur);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.DGVVisiteurs);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormVueMenuUtilisateur";
            this.Text = "Menu utilisateur";
            this.Load += new System.EventHandler(this.FormVueMenuUtilisateur_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripInfos;
        private System.Windows.Forms.ToolStripMenuItem ToolStripQuitter;
        private System.Windows.Forms.DataGridView DGVVisiteurs;
        private System.Windows.Forms.ComboBox comboBoxFiltres;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxSecteur;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblRespPrenom;
        private System.Windows.Forms.Label lblRespId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStripMenuItem ToolStripGerer;
        private System.Windows.Forms.ToolStripMenuItem secteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoireToolStripMenuItem;
    }
}