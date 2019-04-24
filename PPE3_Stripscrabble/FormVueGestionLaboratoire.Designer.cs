namespace PPE3_Stripscrabble
{
    partial class FormVueGestionLaboratoire
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
            this.textBoxNomLabo = new System.Windows.Forms.TextBox();
            this.textBoxIdLabo = new System.Windows.Forms.TextBox();
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.DGVVisiteurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomLabo
            // 
            this.textBoxNomLabo.Location = new System.Drawing.Point(120, 46);
            this.textBoxNomLabo.Name = "textBoxNomLabo";
            this.textBoxNomLabo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomLabo.TabIndex = 0;
            // 
            // textBoxIdLabo
            // 
            this.textBoxIdLabo.Location = new System.Drawing.Point(120, 13);
            this.textBoxIdLabo.Name = "textBoxIdLabo";
            this.textBoxIdLabo.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdLabo.TabIndex = 1;
            // 
            // textBoxResp
            // 
            this.textBoxResp.Location = new System.Drawing.Point(120, 79);
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.Size = new System.Drawing.Size(100, 20);
            this.textBoxResp.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(34, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(80, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID Laboratoire :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(23, 49);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(91, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom Laboratoire :";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(14, 82);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(100, 13);
            this.lblResp.TabIndex = 5;
            this.lblResp.Text = "Nom Responsable :";
            // 
            // DGVVisiteurs
            // 
            this.DGVVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVisiteurs.Location = new System.Drawing.Point(12, 105);
            this.DGVVisiteurs.Name = "DGVVisiteurs";
            this.DGVVisiteurs.Size = new System.Drawing.Size(581, 248);
            this.DGVVisiteurs.TabIndex = 6;
            // 
            // FormVueGestionLaboratoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 365);
            this.Controls.Add(this.DGVVisiteurs);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.textBoxIdLabo);
            this.Controls.Add(this.textBoxNomLabo);
            this.Name = "FormVueGestionLaboratoire";
            this.Text = "FormVueGestionLaboratoire";
            this.Load += new System.EventHandler(this.FormVueGestionLaboratoire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomLabo;
        private System.Windows.Forms.TextBox textBoxIdLabo;
        private System.Windows.Forms.TextBox textBoxResp;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.DataGridView DGVVisiteurs;
    }
}