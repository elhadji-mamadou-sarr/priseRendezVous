namespace priseRendezVous
{
    partial class rfPatient
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.parametresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soinToolStripMenuItem,
            this.rendezvousToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // soinToolStripMenuItem
            // 
            this.soinToolStripMenuItem.Name = "soinToolStripMenuItem";
            this.soinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soinToolStripMenuItem.Text = "Soin";
            this.soinToolStripMenuItem.Click += new System.EventHandler(this.soinToolStripMenuItem_Click);
            // 
            // rendezvousToolStripMenuItem
            // 
            this.rendezvousToolStripMenuItem.Name = "rendezvousToolStripMenuItem";
            this.rendezvousToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rendezvousToolStripMenuItem.Text = "Rendez-Vous";
            this.rendezvousToolStripMenuItem.Click += new System.EventHandler(this.rendezvousToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medecinsToolStripMenuItem,
            this.rendezVousToolStripMenuItem1,
            this.agendaToolStripMenuItem});
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.parametresToolStripMenuItem.Text = "Parametres";
            // 
            // medecinsToolStripMenuItem
            // 
            this.medecinsToolStripMenuItem.Name = "medecinsToolStripMenuItem";
            this.medecinsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medecinsToolStripMenuItem.Text = "Medecins";
            this.medecinsToolStripMenuItem.Click += new System.EventHandler(this.medecinsToolStripMenuItem_Click);
            // 
            // rendezVousToolStripMenuItem1
            // 
            this.rendezVousToolStripMenuItem1.Name = "rendezVousToolStripMenuItem1";
            this.rendezVousToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rendezVousToolStripMenuItem1.Text = "Rendez-Vous";
            this.rendezVousToolStripMenuItem1.Click += new System.EventHandler(this.rendezVousToolStripMenuItem1_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem.Text = "Soin";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(601, 0);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(97, 24);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // rfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 393);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "rfPatient";
            this.Text = "Prise de rendez-vous medical";
            this.Load += new System.EventHandler(this.rfPatient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ToolStripMenuItem medecinsToolStripMenuItem;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ToolStripMenuItem rendezVousToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
    }
}