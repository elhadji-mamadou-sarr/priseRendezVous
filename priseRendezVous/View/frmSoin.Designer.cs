namespace priseRendezVous.View
{
    partial class frmSoin
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
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.bntModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgSoin = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.bntSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(139, 167);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(178, 20);
            this.txtLibelle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cout";
            // 
            // txtCout
            // 
            this.txtCout.Location = new System.Drawing.Point(139, 221);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(178, 20);
            this.txtCout.TabIndex = 2;
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.Color.SlateGray;
            this.btnChoisir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoisir.Location = new System.Drawing.Point(337, 134);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(81, 27);
            this.btnChoisir.TabIndex = 12;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // bntModifier
            // 
            this.bntModifier.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntModifier.Location = new System.Drawing.Point(236, 262);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(81, 27);
            this.bntModifier.TabIndex = 13;
            this.bntModifier.Text = "Modifier";
            this.bntModifier.UseVisualStyleBackColor = false;
            this.bntModifier.Click += new System.EventHandler(this.bntModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SlateGray;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(139, 262);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 27);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgSoin
            // 
            this.dgSoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoin.Location = new System.Drawing.Point(337, 167);
            this.dgSoin.Name = "dgSoin";
            this.dgSoin.Size = new System.Drawing.Size(242, 122);
            this.dgSoin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Parametrage des soin";
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.BackColor = System.Drawing.Color.Tomato;
            this.bntSupprimer.ForeColor = System.Drawing.SystemColors.Control;
            this.bntSupprimer.Location = new System.Drawing.Point(444, 134);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(81, 27);
            this.bntSupprimer.TabIndex = 15;
            this.bntSupprimer.Text = "Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = false;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // frmSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgSoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLibelle);
            this.Name = "frmSoin";
            this.Text = "Soin";
            this.Load += new System.EventHandler(this.frmSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgSoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntSupprimer;
    }
}