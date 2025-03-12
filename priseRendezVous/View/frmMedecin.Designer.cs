namespace AppGroupe2.View
{
    partial class frmMedecin
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroOrdreMedecin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.dgMedecin = new System.Windows.Forms.DataGridView();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(261, 611);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 35);
            this.btnSupprimer.TabIndex = 29;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(140, 611);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 35);
            this.btnModifier.TabIndex = 27;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(18, 611);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 35);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(18, 532);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(349, 26);
            this.txtIdentifiant.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 508);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Identifiant";
            // 
            // txtNumeroOrdreMedecin
            // 
            this.txtNumeroOrdreMedecin.Location = new System.Drawing.Point(18, 451);
            this.txtNumeroOrdreMedecin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroOrdreMedecin.Name = "txtNumeroOrdreMedecin";
            this.txtNumeroOrdreMedecin.Size = new System.Drawing.Size(349, 26);
            this.txtNumeroOrdreMedecin.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Numero Ordre Medecin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Specialite";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(18, 288);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(349, 26);
            this.txtTelephone.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 206);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(18, 125);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(349, 26);
            this.txtAdresse.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adresse";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(18, 43);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(349, 26);
            this.txtNomPrenom.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom prenom";
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(426, 22);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(87, 29);
            this.btnChoisir.TabIndex = 32;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // dgMedecin
            // 
            this.dgMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedecin.Location = new System.Drawing.Point(426, 66);
            this.dgMedecin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.RowHeadersWidth = 62;
            this.dgMedecin.Size = new System.Drawing.Size(924, 642);
            this.dgMedecin.TabIndex = 31;
            this.dgMedecin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedecin_CellContentClick);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(585, 22);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(87, 35);
            this.btnAgenda.TabIndex = 33;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(18, 377);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(355, 26);
            this.txtSpecialite.TabIndex = 34;
            // 
            // frmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.ControlBox = false;
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.dgMedecin);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroOrdreMedecin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMedecin";
            this.Text = "Medecin";
            this.Load += new System.EventHandler(this.frmMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroOrdreMedecin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.DataGridView dgMedecin;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.TextBox txtSpecialite;
    }
}