namespace PPE3_Stripscrabble
{
    partial class FVerifie
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
            this.dgvFraisForfaitises = new System.Windows.Forms.DataGridView();
            this.labForfait = new System.Windows.Forms.Label();
            this.labHorsForfait = new System.Windows.Forms.Label();
            this.dgvFraisHF = new System.Windows.Forms.DataGridView();
            this.btnmodif = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfaitises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHF)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitre
            // 
            this.labTitre.AutoSize = true;
            this.labTitre.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.labTitre.Location = new System.Drawing.Point(50, 19);
            this.labTitre.Name = "labTitre";
            this.labTitre.Size = new System.Drawing.Size(313, 26);
            this.labTitre.TabIndex = 0;
            this.labTitre.Text = "VERIFIER UNE DEMANDE DE FRAIS";
            // 
            // dgvFraisForfaitises
            // 
            this.dgvFraisForfaitises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisForfaitises.Location = new System.Drawing.Point(28, 121);
            this.dgvFraisForfaitises.Name = "dgvFraisForfaitises";
            this.dgvFraisForfaitises.Size = new System.Drawing.Size(359, 159);
            this.dgvFraisForfaitises.TabIndex = 1;
            // 
            // labForfait
            // 
            this.labForfait.AutoSize = true;
            this.labForfait.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labForfait.Location = new System.Drawing.Point(21, 88);
            this.labForfait.Name = "labForfait";
            this.labForfait.Size = new System.Drawing.Size(308, 19);
            this.labForfait.TabIndex = 5;
            this.labForfait.Text = "Demande de Remboursement Frais Forfaitisés";
            // 
            // labHorsForfait
            // 
            this.labHorsForfait.AutoSize = true;
            this.labHorsForfait.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHorsForfait.Location = new System.Drawing.Point(24, 307);
            this.labHorsForfait.Name = "labHorsForfait";
            this.labHorsForfait.Size = new System.Drawing.Size(334, 19);
            this.labHorsForfait.TabIndex = 6;
            this.labHorsForfait.Text = "Demande de Remboursement de frais Hors Forfait";
            // 
            // dgvFraisHF
            // 
            this.dgvFraisHF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisHF.Location = new System.Drawing.Point(28, 339);
            this.dgvFraisHF.Name = "dgvFraisHF";
            this.dgvFraisHF.Size = new System.Drawing.Size(362, 150);
            this.dgvFraisHF.TabIndex = 7;
            // 
            // btnmodif
            // 
            this.btnmodif.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.Location = new System.Drawing.Point(196, 517);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(75, 23);
            this.btnmodif.TabIndex = 8;
            this.btnmodif.Text = "MODIFIER";
            this.btnmodif.UseVisualStyleBackColor = true;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.Location = new System.Drawing.Point(288, 517);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(75, 23);
            this.btnvalider.TabIndex = 9;
            this.btnvalider.Text = "VALIDER";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // FVerifie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 561);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.dgvFraisHF);
            this.Controls.Add(this.labHorsForfait);
            this.Controls.Add(this.labForfait);
            this.Controls.Add(this.dgvFraisForfaitises);
            this.Controls.Add(this.labTitre);
            this.Name = "FVerifie";
            this.Text = "FVerifie";
            this.Load += new System.EventHandler(this.FVerifie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfaitises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.DataGridView dgvFraisForfaitises;
        private System.Windows.Forms.Label labForfait;
        private System.Windows.Forms.Label labHorsForfait;
        private System.Windows.Forms.DataGridView dgvFraisHF;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnvalider;
    }
}