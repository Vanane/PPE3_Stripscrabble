﻿namespace PPE3_Stripscrabble
{
    partial class FCloture
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
            this.TestCloture = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestCloture
            // 
            this.TestCloture.AutoSize = true;
            this.TestCloture.Location = new System.Drawing.Point(31, 20);
            this.TestCloture.Name = "TestCloture";
            this.TestCloture.Size = new System.Drawing.Size(61, 13);
            this.TestCloture.TabIndex = 0;
            this.TestCloture.Text = "TestCloture";
            // 
            // FCloture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestCloture);
            this.Name = "FCloture";
            this.Text = "FCloture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestCloture;
    }
}