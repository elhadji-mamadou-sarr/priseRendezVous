namespace AppGroupe2.View
{
    partial class frmRendezVous
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.dgRendezVous = new System.Windows.Forms.DataGridView();
            this.bntModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSoin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateRv = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCreneaux = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Statut";
            // 
            // txtStatut
            // 
            this.txtStatut.Location = new System.Drawing.Point(156, 208);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(210, 20);
            this.txtStatut.TabIndex = 45;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimer.Location = new System.Drawing.Point(515, 153);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(94, 27);
            this.btnSupprimer.TabIndex = 44;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.Color.SlateGray;
            this.btnChoisir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoisir.Location = new System.Drawing.Point(401, 153);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(94, 27);
            this.btnChoisir.TabIndex = 43;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = false;
            // 
            // dgRendezVous
            // 
            this.dgRendezVous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRendezVous.Location = new System.Drawing.Point(401, 194);
            this.dgRendezVous.Name = "dgRendezVous";
            this.dgRendezVous.Size = new System.Drawing.Size(373, 233);
            this.dgRendezVous.TabIndex = 42;
            // 
            // bntModifier
            // 
            this.bntModifier.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntModifier.Location = new System.Drawing.Point(272, 400);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(94, 27);
            this.bntModifier.TabIndex = 41;
            this.bntModifier.Text = "Modifier";
            this.bntModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SlateGray;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(156, 400);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 27);
            this.btnAjouter.TabIndex = 40;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Soin";
            // 
            // cbSoin
            // 
            this.cbSoin.FormattingEnabled = true;
            this.cbSoin.Location = new System.Drawing.Point(156, 355);
            this.cbSoin.Name = "cbSoin";
            this.cbSoin.Size = new System.Drawing.Size(210, 21);
            this.cbSoin.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Patient";
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(156, 306);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(210, 21);
            this.cbPatient.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Medecin";
            // 
            // cbMedecin
            // 
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(156, 257);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(210, 21);
            this.cbMedecin.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Date du rendez-vous";
            // 
            // dtpDateRv
            // 
            this.dtpDateRv.Location = new System.Drawing.Point(156, 160);
            this.dtpDateRv.Name = "dtpDateRv";
            this.dtpDateRv.Size = new System.Drawing.Size(210, 20);
            this.dtpDateRv.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Parametrage des rendez-vous";
            // 
            // cbCreneaux
            // 
            this.cbCreneaux.FormattingEnabled = true;
            this.cbCreneaux.Location = new System.Drawing.Point(10, 400);
            this.cbCreneaux.Name = "cbCreneaux";
            this.cbCreneaux.Size = new System.Drawing.Size(140, 21);
            this.cbCreneaux.TabIndex = 49;
            this.cbCreneaux.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Creneau";
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimer.Location = new System.Drawing.Point(639, 153);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(94, 27);
            this.btnImprimer.TabIndex = 48;
            this.btnImprimer.Text = "Supprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // frmRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 515);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCreneaux);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatut);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.dgRendezVous);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSoin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMedecin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateRv);
            this.Controls.Add(this.label3);
            this.Name = "frmRendezVous";
            this.Text = "RendezVous";
            this.Load += new System.EventHandler(this.frmRendezVous_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatut;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.DataGridView dgRendezVous;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSoin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateRv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCreneaux;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImprimer;
    }
}