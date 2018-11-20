namespace PPE3_Stripscrabble
{
    partial class FormVueModifMdpConfirmation
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
            this.textBoxAncien = new System.Windows.Forms.TextBox();
            this.textBoxNouveauConf = new System.Windows.Forms.TextBox();
            this.textBoxNouveau = new System.Windows.Forms.TextBox();
            this.lvlNouveau = new System.Windows.Forms.Label();
            this.lblVeri = new System.Windows.Forms.Label();
            this.lblEntrer = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAncien
            // 
            this.textBoxAncien.Location = new System.Drawing.Point(174, 24);
            this.textBoxAncien.Name = "textBoxAncien";
            this.textBoxAncien.Size = new System.Drawing.Size(150, 20);
            this.textBoxAncien.TabIndex = 0;
            // 
            // textBoxNouveauConf
            // 
            this.textBoxNouveauConf.Location = new System.Drawing.Point(174, 110);
            this.textBoxNouveauConf.Name = "textBoxNouveauConf";
            this.textBoxNouveauConf.Size = new System.Drawing.Size(150, 20);
            this.textBoxNouveauConf.TabIndex = 2;
            // 
            // textBoxNouveau
            // 
            this.textBoxNouveau.Location = new System.Drawing.Point(174, 67);
            this.textBoxNouveau.Name = "textBoxNouveau";
            this.textBoxNouveau.Size = new System.Drawing.Size(150, 20);
            this.textBoxNouveau.TabIndex = 1;
            // 
            // lvlNouveau
            // 
            this.lvlNouveau.AutoSize = true;
            this.lvlNouveau.Location = new System.Drawing.Point(43, 70);
            this.lvlNouveau.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lvlNouveau.Name = "lvlNouveau";
            this.lvlNouveau.Size = new System.Drawing.Size(123, 13);
            this.lvlNouveau.TabIndex = 3;
            this.lvlNouveau.Text = "Nouveau mot de passe :";
            // 
            // lblVeri
            // 
            this.lblVeri.AutoSize = true;
            this.lblVeri.Location = new System.Drawing.Point(31, 113);
            this.lblVeri.Name = "lblVeri";
            this.lblVeri.Size = new System.Drawing.Size(137, 13);
            this.lblVeri.TabIndex = 4;
            this.lblVeri.Text = "Confirmation mot de passe :";
            // 
            // lblEntrer
            // 
            this.lblEntrer.AutoSize = true;
            this.lblEntrer.Location = new System.Drawing.Point(32, 27);
            this.lblEntrer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lblEntrer.Name = "lblEntrer";
            this.lblEntrer.Size = new System.Drawing.Size(136, 13);
            this.lblEntrer.TabIndex = 5;
            this.lblEntrer.Text = "Entrez votre mot de passe :";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(249, 144);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Confirmer";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(30, 149);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 13);
            this.lblErr.TabIndex = 8;
            // 
            // FormVueModifMdpConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 182);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.lblEntrer);
            this.Controls.Add(this.lblVeri);
            this.Controls.Add(this.lvlNouveau);
            this.Controls.Add(this.textBoxNouveau);
            this.Controls.Add(this.textBoxNouveauConf);
            this.Controls.Add(this.textBoxAncien);
            this.Name = "FormVueModifMdpConfirmation";
            this.Padding = new System.Windows.Forms.Padding(27);
            this.Text = "FormVueModifMdpConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAncien;
        private System.Windows.Forms.TextBox textBoxNouveauConf;
        private System.Windows.Forms.TextBox textBoxNouveau;
        private System.Windows.Forms.Label lvlNouveau;
        private System.Windows.Forms.Label lblVeri;
        private System.Windows.Forms.Label lblEntrer;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label lblErr;
    }
}