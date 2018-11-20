namespace PPE3_Stripscrabble
{
    partial class FormVueMenu
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
            this.lblTest = new System.Windows.Forms.Label();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonFormOriane = new System.Windows.Forms.Button();
            this.buttonFormVanane = new System.Windows.Forms.Button();
            this.buttonFormIlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Calibri Light", 32F);
            this.lblTest.Location = new System.Drawing.Point(12, 9);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(126, 53);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "label1";
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnexion.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.ForeColor = System.Drawing.Color.White;
            this.buttonDeconnexion.Location = new System.Drawing.Point(752, 388);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(120, 50);
            this.buttonDeconnexion.TabIndex = 1;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = false;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonFormOriane
            // 
            this.buttonFormOriane.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.buttonFormOriane.Location = new System.Drawing.Point(331, 129);
            this.buttonFormOriane.Name = "buttonFormOriane";
            this.buttonFormOriane.Size = new System.Drawing.Size(120, 57);
            this.buttonFormOriane.TabIndex = 2;
            this.buttonFormOriane.Text = "Test Form Oriane";
            this.buttonFormOriane.UseVisualStyleBackColor = true;
            this.buttonFormOriane.Click += new System.EventHandler(this.buttonFormOriane_Click);
            // 
            // buttonFormVanane
            // 
            this.buttonFormVanane.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.buttonFormVanane.Location = new System.Drawing.Point(331, 241);
            this.buttonFormVanane.Name = "buttonFormVanane";
            this.buttonFormVanane.Size = new System.Drawing.Size(120, 57);
            this.buttonFormVanane.TabIndex = 3;
            this.buttonFormVanane.Text = "Test Form Alvin";
            this.buttonFormVanane.UseVisualStyleBackColor = true;
            this.buttonFormVanane.Click += new System.EventHandler(this.buttonFormVanane_Click);
            // 
            // buttonFormIlan
            // 
            this.buttonFormIlan.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.buttonFormIlan.Location = new System.Drawing.Point(457, 186);
            this.buttonFormIlan.Name = "buttonFormIlan";
            this.buttonFormIlan.Size = new System.Drawing.Size(120, 56);
            this.buttonFormIlan.TabIndex = 4;
            this.buttonFormIlan.Text = "Test Form Ilan";
            this.buttonFormIlan.UseVisualStyleBackColor = true;
            // 
            // FormVueMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.buttonFormIlan);
            this.Controls.Add(this.buttonFormVanane);
            this.Controls.Add(this.buttonFormOriane);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.lblTest);
            this.Name = "FormVueMenu";
            this.Text = "FormVueMenu";
            this.Load += new System.EventHandler(this.FormVueMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Button buttonFormOriane;
        private System.Windows.Forms.Button buttonFormVanane;
        private System.Windows.Forms.Button buttonFormIlan;
    }
}