namespace TpErgonogaf
{
    partial class frmListeCollabos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeCollabos));
            this.grpRechercher = new System.Windows.Forms.GroupBox();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.btnRechService = new System.Windows.Forms.Button();
            this.btnRechNom = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiche = new System.Windows.Forms.DataGridViewLinkColumn();
            this.grpRechercher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRechercher
            // 
            this.grpRechercher.Controls.Add(this.cbxService);
            this.grpRechercher.Controls.Add(this.btnRechService);
            this.grpRechercher.Controls.Add(this.btnRechNom);
            this.grpRechercher.Controls.Add(this.txtNom);
            this.grpRechercher.Controls.Add(this.lblService);
            this.grpRechercher.Controls.Add(this.lblNom);
            this.grpRechercher.Location = new System.Drawing.Point(34, 24);
            this.grpRechercher.Name = "grpRechercher";
            this.grpRechercher.Size = new System.Drawing.Size(699, 104);
            this.grpRechercher.TabIndex = 0;
            this.grpRechercher.TabStop = false;
            this.grpRechercher.Text = "Rechercher Collaborateurs";
            // 
            // cbxService
            // 
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Items.AddRange(new object[] {
            "Comptabilité",
            "Administration",
            "Accueil",
            "Service Après-Vente"});
            this.cbxService.Location = new System.Drawing.Point(115, 73);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(282, 21);
            this.cbxService.TabIndex = 6;
            // 
            // btnRechService
            // 
            this.btnRechService.Location = new System.Drawing.Point(458, 73);
            this.btnRechService.Name = "btnRechService";
            this.btnRechService.Size = new System.Drawing.Size(116, 23);
            this.btnRechService.TabIndex = 5;
            this.btnRechService.Text = "Rechercher";
            this.btnRechService.UseVisualStyleBackColor = true;
            // 
            // btnRechNom
            // 
            this.btnRechNom.Location = new System.Drawing.Point(458, 22);
            this.btnRechNom.Name = "btnRechNom";
            this.btnRechNom.Size = new System.Drawing.Size(116, 23);
            this.btnRechNom.TabIndex = 4;
            this.btnRechNom.Text = "Rechercher";
            this.btnRechNom.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(115, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(282, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(31, 78);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 1;
            this.lblService.Text = "Service :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(28, 27);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Qualification,
            this.Statut,
            this.Contrat,
            this.Salaire,
            this.Fiche});
            this.dataGridView1.Location = new System.Drawing.Point(36, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(698, 408);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(591, 408);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.Name = "Qualification";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            // 
            // Contrat
            // 
            this.Contrat.HeaderText = "Contrat";
            this.Contrat.Name = "Contrat";
            // 
            // Salaire
            // 
            this.Salaire.HeaderText = "Salaire";
            this.Salaire.Name = "Salaire";
            // 
            // Fiche
            // 
            this.Fiche.HeaderText = "Fiche Perso";
            this.Fiche.Name = "Fiche";
            // 
            // frmListeCollabos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 441);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpRechercher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListeCollabos";
            this.Text = "Liste des Collaborateurs";
            this.grpRechercher.ResumeLayout(false);
            this.grpRechercher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRechercher;
        private System.Windows.Forms.Button btnRechService;
        private System.Windows.Forms.Button btnRechNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cbxService;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salaire;
        private System.Windows.Forms.DataGridViewLinkColumn Fiche;
    }
}