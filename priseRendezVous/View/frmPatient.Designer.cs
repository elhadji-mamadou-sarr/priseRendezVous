namespace priseRendezVous.View
{
    partial class frmPatient
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
            this.dgPatient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroupSanguin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.bntModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPatient
            // 
            this.dgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatient.Location = new System.Drawing.Point(299, 79);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.Size = new System.Drawing.Size(548, 337);
            this.dgPatient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom et Prenom";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(29, 68);
            this.txtNomPrenom.Multiline = true;
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(249, 26);
            this.txtNomPrenom.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 174);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(29, 227);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(249, 27);
            this.txtTel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telephone";
            // 
            // txtGroupSanguin
            // 
            this.txtGroupSanguin.Location = new System.Drawing.Point(29, 280);
            this.txtGroupSanguin.Multiline = true;
            this.txtGroupSanguin.Name = "txtGroupSanguin";
            this.txtGroupSanguin.Size = new System.Drawing.Size(249, 27);
            this.txtGroupSanguin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Groupe Sanguin";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(29, 333);
            this.txtPoids.Multiline = true;
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(249, 27);
            this.txtPoids.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Poids";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(29, 121);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(249, 24);
            this.txtAdresse.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adresse";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SlateGray;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(29, 378);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 27);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // bntModifier
            // 
            this.bntModifier.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntModifier.Location = new System.Drawing.Point(113, 378);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(81, 27);
            this.bntModifier.TabIndex = 9;
            this.bntModifier.Text = "Modifier";
            this.bntModifier.UseVisualStyleBackColor = false;
            this.bntModifier.Click += new System.EventHandler(this.bntModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimer.Location = new System.Drawing.Point(197, 378);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(81, 27);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.Color.SlateGray;
            this.btnChoisir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoisir.Location = new System.Drawing.Point(299, 35);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(81, 27);
            this.btnChoisir.TabIndex = 8;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 428);
            this.ControlBox = false;
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGroupSanguin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPatient);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.frmPatient_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGroupSanguin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChoisir;
    }
}