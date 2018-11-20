namespace PPE3_Stripscrabble
{
    partial class FRapportVisite
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
            this.lblAuteurRapport = new System.Windows.Forms.Label();
            this.lblAuteurRapportSelect = new System.Windows.Forms.Label();
            this.lblMedecinVisite = new System.Windows.Forms.Label();
            this.cbBoxMed = new System.Windows.Forms.ComboBox();
            this.lblNomMed = new System.Windows.Forms.Label();
            this.lblnomMedSelec = new System.Windows.Forms.Label();
            this.lblMedocPresent = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblPrenomMed = new System.Windows.Forms.Label();
            this.lblPrenomMedSelect = new System.Windows.Forms.Label();
            this.cbBoxMotif = new System.Windows.Forms.ComboBox();
            this.lblRapportVisite = new System.Windows.Forms.Label();
            this.rTxtBoxRapport = new System.Windows.Forms.RichTextBox();
            this.lblMedocEchantillon = new System.Windows.Forms.Label();
            this.dgvMedocPresent = new System.Windows.Forms.DataGridView();
            this.btnAjoutMedocPresent = new System.Windows.Forms.Button();
            this.btnRetirMedocPresent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRetirMedocEchant = new System.Windows.Forms.Button();
            this.btnAjoutMedocEchant = new System.Windows.Forms.Button();
            this.btnAnnulerRapport = new System.Windows.Forms.Button();
            this.btnValiderRapport = new System.Windows.Forms.Button();
            this.cbRemplacant = new System.Windows.Forms.CheckBox();
            this.btnAjoutRemplacant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedocPresent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuteurRapport
            // 
            this.lblAuteurRapport.AutoSize = true;
            this.lblAuteurRapport.Location = new System.Drawing.Point(12, 9);
            this.lblAuteurRapport.Name = "lblAuteurRapport";
            this.lblAuteurRapport.Size = new System.Drawing.Size(104, 13);
            this.lblAuteurRapport.TabIndex = 0;
            this.lblAuteurRapport.Text = "Rapport rédigé par : ";
            // 
            // lblAuteurRapportSelect
            // 
            this.lblAuteurRapportSelect.AutoSize = true;
            this.lblAuteurRapportSelect.Location = new System.Drawing.Point(179, 9);
            this.lblAuteurRapportSelect.Name = "lblAuteurRapportSelect";
            this.lblAuteurRapportSelect.Size = new System.Drawing.Size(79, 13);
            this.lblAuteurRapportSelect.TabIndex = 1;
            this.lblAuteurRapportSelect.Text = "Auteur Rapport";
            // 
            // lblMedecinVisite
            // 
            this.lblMedecinVisite.AutoSize = true;
            this.lblMedecinVisite.Location = new System.Drawing.Point(12, 49);
            this.lblMedecinVisite.Name = "lblMedecinVisite";
            this.lblMedecinVisite.Size = new System.Drawing.Size(84, 13);
            this.lblMedecinVisite.TabIndex = 2;
            this.lblMedecinVisite.Text = "Médecin visité : ";
            // 
            // cbBoxMed
            // 
            this.cbBoxMed.FormattingEnabled = true;
            this.cbBoxMed.Location = new System.Drawing.Point(182, 46);
            this.cbBoxMed.Name = "cbBoxMed";
            this.cbBoxMed.Size = new System.Drawing.Size(121, 21);
            this.cbBoxMed.TabIndex = 3;
            this.cbBoxMed.SelectedIndexChanged += new System.EventHandler(this.cbBoxMed_SelectedIndexChanged);
            // 
            // lblNomMed
            // 
            this.lblNomMed.AutoSize = true;
            this.lblNomMed.Location = new System.Drawing.Point(309, 49);
            this.lblNomMed.Name = "lblNomMed";
            this.lblNomMed.Size = new System.Drawing.Size(38, 13);
            this.lblNomMed.TabIndex = 4;
            this.lblNomMed.Text = "Nom : ";
            // 
            // lblnomMedSelec
            // 
            this.lblnomMedSelec.AutoSize = true;
            this.lblnomMedSelec.Location = new System.Drawing.Point(368, 49);
            this.lblnomMedSelec.Name = "lblnomMedSelec";
            this.lblnomMedSelec.Size = new System.Drawing.Size(70, 13);
            this.lblnomMedSelec.TabIndex = 5;
            this.lblnomMedSelec.Text = "nom médecin";
            // 
            // lblMedocPresent
            // 
            this.lblMedocPresent.AutoSize = true;
            this.lblMedocPresent.Location = new System.Drawing.Point(12, 91);
            this.lblMedocPresent.Name = "lblMedocPresent";
            this.lblMedocPresent.Size = new System.Drawing.Size(116, 13);
            this.lblMedocPresent.TabIndex = 6;
            this.lblMedocPresent.Text = "Médicament Présenté :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(12, 331);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(39, 13);
            this.lblMotif.TabIndex = 8;
            this.lblMotif.Text = "Motif : ";
            // 
            // lblPrenomMed
            // 
            this.lblPrenomMed.AutoSize = true;
            this.lblPrenomMed.Location = new System.Drawing.Point(309, 62);
            this.lblPrenomMed.Name = "lblPrenomMed";
            this.lblPrenomMed.Size = new System.Drawing.Size(52, 13);
            this.lblPrenomMed.TabIndex = 9;
            this.lblPrenomMed.Text = "Prenom : ";
            // 
            // lblPrenomMedSelect
            // 
            this.lblPrenomMedSelect.AutoSize = true;
            this.lblPrenomMedSelect.Location = new System.Drawing.Point(367, 62);
            this.lblPrenomMedSelect.Name = "lblPrenomMedSelect";
            this.lblPrenomMedSelect.Size = new System.Drawing.Size(85, 13);
            this.lblPrenomMedSelect.TabIndex = 10;
            this.lblPrenomMedSelect.Text = "prénom médecin";
            // 
            // cbBoxMotif
            // 
            this.cbBoxMotif.FormattingEnabled = true;
            this.cbBoxMotif.Location = new System.Drawing.Point(182, 328);
            this.cbBoxMotif.Name = "cbBoxMotif";
            this.cbBoxMotif.Size = new System.Drawing.Size(121, 21);
            this.cbBoxMotif.TabIndex = 11;
            // 
            // lblRapportVisite
            // 
            this.lblRapportVisite.AutoSize = true;
            this.lblRapportVisite.Location = new System.Drawing.Point(12, 371);
            this.lblRapportVisite.Name = "lblRapportVisite";
            this.lblRapportVisite.Size = new System.Drawing.Size(96, 13);
            this.lblRapportVisite.TabIndex = 12;
            this.lblRapportVisite.Text = "Rapport de visite : ";
            // 
            // rTxtBoxRapport
            // 
            this.rTxtBoxRapport.Location = new System.Drawing.Point(182, 368);
            this.rTxtBoxRapport.Name = "rTxtBoxRapport";
            this.rTxtBoxRapport.Size = new System.Drawing.Size(541, 103);
            this.rTxtBoxRapport.TabIndex = 13;
            this.rTxtBoxRapport.Text = "";
            // 
            // lblMedocEchantillon
            // 
            this.lblMedocEchantillon.AutoSize = true;
            this.lblMedocEchantillon.Location = new System.Drawing.Point(12, 197);
            this.lblMedocEchantillon.Name = "lblMedocEchantillon";
            this.lblMedocEchantillon.Size = new System.Drawing.Size(59, 13);
            this.lblMedocEchantillon.TabIndex = 14;
            this.lblMedocEchantillon.Text = "Echantillon";
            // 
            // dgvMedocPresent
            // 
            this.dgvMedocPresent.AllowUserToAddRows = false;
            this.dgvMedocPresent.AllowUserToDeleteRows = false;
            this.dgvMedocPresent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedocPresent.Location = new System.Drawing.Point(182, 91);
            this.dgvMedocPresent.Name = "dgvMedocPresent";
            this.dgvMedocPresent.ReadOnly = true;
            this.dgvMedocPresent.Size = new System.Drawing.Size(304, 85);
            this.dgvMedocPresent.TabIndex = 15;
            // 
            // btnAjoutMedocPresent
            // 
            this.btnAjoutMedocPresent.Location = new System.Drawing.Point(516, 91);
            this.btnAjoutMedocPresent.Name = "btnAjoutMedocPresent";
            this.btnAjoutMedocPresent.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutMedocPresent.TabIndex = 16;
            this.btnAjoutMedocPresent.Text = "Ajouter";
            this.btnAjoutMedocPresent.UseVisualStyleBackColor = true;
            this.btnAjoutMedocPresent.Click += new System.EventHandler(this.btnAjoutMedocPresent_Click);
            // 
            // btnRetirMedocPresent
            // 
            this.btnRetirMedocPresent.Location = new System.Drawing.Point(516, 121);
            this.btnRetirMedocPresent.Name = "btnRetirMedocPresent";
            this.btnRetirMedocPresent.Size = new System.Drawing.Size(75, 23);
            this.btnRetirMedocPresent.TabIndex = 17;
            this.btnRetirMedocPresent.Text = "Retirer";
            this.btnRetirMedocPresent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(304, 85);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnRetirMedocEchant
            // 
            this.btnRetirMedocEchant.Location = new System.Drawing.Point(516, 227);
            this.btnRetirMedocEchant.Name = "btnRetirMedocEchant";
            this.btnRetirMedocEchant.Size = new System.Drawing.Size(75, 23);
            this.btnRetirMedocEchant.TabIndex = 20;
            this.btnRetirMedocEchant.Text = "Retirer";
            this.btnRetirMedocEchant.UseVisualStyleBackColor = true;
            // 
            // btnAjoutMedocEchant
            // 
            this.btnAjoutMedocEchant.Location = new System.Drawing.Point(516, 197);
            this.btnAjoutMedocEchant.Name = "btnAjoutMedocEchant";
            this.btnAjoutMedocEchant.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutMedocEchant.TabIndex = 19;
            this.btnAjoutMedocEchant.Text = "Ajouter";
            this.btnAjoutMedocEchant.UseVisualStyleBackColor = true;
            this.btnAjoutMedocEchant.Click += new System.EventHandler(this.btnAjoutMedocEchant_Click);
            // 
            // btnAnnulerRapport
            // 
            this.btnAnnulerRapport.Location = new System.Drawing.Point(648, 491);
            this.btnAnnulerRapport.Name = "btnAnnulerRapport";
            this.btnAnnulerRapport.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerRapport.TabIndex = 21;
            this.btnAnnulerRapport.Text = "Annuler";
            this.btnAnnulerRapport.UseVisualStyleBackColor = true;
            this.btnAnnulerRapport.Click += new System.EventHandler(this.btnAnnulerRapport_Click);
            // 
            // btnValiderRapport
            // 
            this.btnValiderRapport.Location = new System.Drawing.Point(553, 491);
            this.btnValiderRapport.Name = "btnValiderRapport";
            this.btnValiderRapport.Size = new System.Drawing.Size(75, 23);
            this.btnValiderRapport.TabIndex = 22;
            this.btnValiderRapport.Text = "Valider";
            this.btnValiderRapport.UseVisualStyleBackColor = true;
            // 
            // cbRemplacant
            // 
            this.cbRemplacant.AutoSize = true;
            this.cbRemplacant.Location = new System.Drawing.Point(458, 48);
            this.cbRemplacant.Name = "cbRemplacant";
            this.cbRemplacant.Size = new System.Drawing.Size(78, 17);
            this.cbRemplacant.TabIndex = 23;
            this.cbRemplacant.Text = "remplacant";
            this.cbRemplacant.UseVisualStyleBackColor = true;
            // 
            // btnAjoutRemplacant
            // 
            this.btnAjoutRemplacant.Location = new System.Drawing.Point(542, 44);
            this.btnAjoutRemplacant.Name = "btnAjoutRemplacant";
            this.btnAjoutRemplacant.Size = new System.Drawing.Size(124, 23);
            this.btnAjoutRemplacant.TabIndex = 24;
            this.btnAjoutRemplacant.Text = "Ajouter un Remplacant";
            this.btnAjoutRemplacant.UseVisualStyleBackColor = true;
            // 
            // FRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.btnAjoutRemplacant);
            this.Controls.Add(this.cbRemplacant);
            this.Controls.Add(this.btnValiderRapport);
            this.Controls.Add(this.btnAnnulerRapport);
            this.Controls.Add(this.btnRetirMedocEchant);
            this.Controls.Add(this.btnAjoutMedocEchant);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRetirMedocPresent);
            this.Controls.Add(this.btnAjoutMedocPresent);
            this.Controls.Add(this.dgvMedocPresent);
            this.Controls.Add(this.lblMedocEchantillon);
            this.Controls.Add(this.rTxtBoxRapport);
            this.Controls.Add(this.lblRapportVisite);
            this.Controls.Add(this.cbBoxMotif);
            this.Controls.Add(this.lblPrenomMedSelect);
            this.Controls.Add(this.lblPrenomMed);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblMedocPresent);
            this.Controls.Add(this.lblnomMedSelec);
            this.Controls.Add(this.lblNomMed);
            this.Controls.Add(this.cbBoxMed);
            this.Controls.Add(this.lblMedecinVisite);
            this.Controls.Add(this.lblAuteurRapportSelect);
            this.Controls.Add(this.lblAuteurRapport);
            this.Name = "FRapportVisite";
            this.Text = "FRapportVisite";
            this.Load += new System.EventHandler(this.FRapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedocPresent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuteurRapport;
        private System.Windows.Forms.Label lblAuteurRapportSelect;
        private System.Windows.Forms.Label lblMedecinVisite;
        private System.Windows.Forms.ComboBox cbBoxMed;
        private System.Windows.Forms.Label lblNomMed;
        private System.Windows.Forms.Label lblnomMedSelec;
        private System.Windows.Forms.Label lblMedocPresent;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblPrenomMed;
        private System.Windows.Forms.Label lblPrenomMedSelect;
        private System.Windows.Forms.ComboBox cbBoxMotif;
        private System.Windows.Forms.Label lblRapportVisite;
        private System.Windows.Forms.RichTextBox rTxtBoxRapport;
        private System.Windows.Forms.Label lblMedocEchantillon;
        private System.Windows.Forms.DataGridView dgvMedocPresent;
        private System.Windows.Forms.Button btnAjoutMedocPresent;
        private System.Windows.Forms.Button btnRetirMedocPresent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRetirMedocEchant;
        private System.Windows.Forms.Button btnAjoutMedocEchant;
        private System.Windows.Forms.Button btnAnnulerRapport;
        private System.Windows.Forms.Button btnValiderRapport;
        private System.Windows.Forms.CheckBox cbRemplacant;
        private System.Windows.Forms.Button btnAjoutRemplacant;
    }
}