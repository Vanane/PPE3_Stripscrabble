namespace PPE3_Stripscrabble
{
    partial class FormVueGestionRegion
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
            this.textBoxIdRegion = new System.Windows.Forms.TextBox();
            this.textBoxNomRegion = new System.Windows.Forms.TextBox();
            this.lblIdR = new System.Windows.Forms.Label();
            this.lblNomR = new System.Windows.Forms.Label();
            this.DGVVisiteurs = new System.Windows.Forms.DataGridView();
            this.lblNomResp = new System.Windows.Forms.Label();
            this.btnModifRegion = new System.Windows.Forms.Button();
            this.comboBoxVisiteurs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIdRegion
            // 
            this.textBoxIdRegion.Location = new System.Drawing.Point(130, 12);
            this.textBoxIdRegion.Name = "textBoxIdRegion";
            this.textBoxIdRegion.ReadOnly = true;
            this.textBoxIdRegion.Size = new System.Drawing.Size(120, 20);
            this.textBoxIdRegion.TabIndex = 0;
            // 
            // textBoxNomRegion
            // 
            this.textBoxNomRegion.Location = new System.Drawing.Point(130, 51);
            this.textBoxNomRegion.Name = "textBoxNomRegion";
            this.textBoxNomRegion.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomRegion.TabIndex = 1;
            // 
            // lblIdR
            // 
            this.lblIdR.AutoSize = true;
            this.lblIdR.Location = new System.Drawing.Point(63, 15);
            this.lblIdR.Name = "lblIdR";
            this.lblIdR.Size = new System.Drawing.Size(61, 13);
            this.lblIdR.TabIndex = 2;
            this.lblIdR.Text = "ID Région :";
            // 
            // lblNomR
            // 
            this.lblNomR.AutoSize = true;
            this.lblNomR.Location = new System.Drawing.Point(52, 54);
            this.lblNomR.Name = "lblNomR";
            this.lblNomR.Size = new System.Drawing.Size(72, 13);
            this.lblNomR.TabIndex = 3;
            this.lblNomR.Text = "Nom Région :";
            // 
            // DGVVisiteurs
            // 
            this.DGVVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVisiteurs.Location = new System.Drawing.Point(12, 177);
            this.DGVVisiteurs.Name = "DGVVisiteurs";
            this.DGVVisiteurs.Size = new System.Drawing.Size(637, 283);
            this.DGVVisiteurs.TabIndex = 4;
            this.DGVVisiteurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVisiteurs_CellClick);
            // 
            // lblNomResp
            // 
            this.lblNomResp.AutoSize = true;
            this.lblNomResp.Location = new System.Drawing.Point(12, 95);
            this.lblNomResp.Name = "lblNomResp";
            this.lblNomResp.Size = new System.Drawing.Size(112, 13);
            this.lblNomResp.TabIndex = 6;
            this.lblNomResp.Text = "Responsable Région :";
            // 
            // btnModifRegion
            // 
            this.btnModifRegion.Location = new System.Drawing.Point(175, 118);
            this.btnModifRegion.Name = "btnModifRegion";
            this.btnModifRegion.Size = new System.Drawing.Size(75, 23);
            this.btnModifRegion.TabIndex = 7;
            this.btnModifRegion.Text = "Modifier";
            this.btnModifRegion.UseVisualStyleBackColor = true;
            this.btnModifRegion.Click += new System.EventHandler(this.btnModifRegion_Click);
            // 
            // comboBoxVisiteurs
            // 
            this.comboBoxVisiteurs.FormattingEnabled = true;
            this.comboBoxVisiteurs.Location = new System.Drawing.Point(129, 92);
            this.comboBoxVisiteurs.Name = "comboBoxVisiteurs";
            this.comboBoxVisiteurs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisiteurs.TabIndex = 8;
            // 
            // FormVueInfoRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 472);
            this.Controls.Add(this.comboBoxVisiteurs);
            this.Controls.Add(this.btnModifRegion);
            this.Controls.Add(this.lblNomResp);
            this.Controls.Add(this.DGVVisiteurs);
            this.Controls.Add(this.lblNomR);
            this.Controls.Add(this.lblIdR);
            this.Controls.Add(this.textBoxNomRegion);
            this.Controls.Add(this.textBoxIdRegion);
            this.Name = "FormVueInfoRegion";
            this.Text = "FormVueInfoRegion";
            this.Load += new System.EventHandler(this.FormVueInfoRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdRegion;
        private System.Windows.Forms.TextBox textBoxNomRegion;
        private System.Windows.Forms.Label lblIdR;
        private System.Windows.Forms.Label lblNomR;
        private System.Windows.Forms.DataGridView DGVVisiteurs;
        private System.Windows.Forms.Label lblNomResp;
        private System.Windows.Forms.Button btnModifRegion;
        private System.Windows.Forms.ComboBox comboBoxVisiteurs;
    }
}