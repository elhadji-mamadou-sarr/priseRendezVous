namespace AppGroupe2
{
    partial class frmMDI
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
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rougeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.couleurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.seDeconnecterToolStripMenuItem.Text = "&Se Deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 34);
            this.toolStripMenuItem2.Text = "&";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // couleurToolStripMenuItem
            // 
            this.couleurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rougeToolStripMenuItem,
            this.medecinToolStripMenuItem,
            this.rendezvousToolStripMenuItem,
            this.soinToolStripMenuItem});
            this.couleurToolStripMenuItem.Name = "couleurToolStripMenuItem";
            this.couleurToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.couleurToolStripMenuItem.Text = "Parametre";
            // 
            // rougeToolStripMenuItem
            // 
            this.rougeToolStripMenuItem.Name = "rougeToolStripMenuItem";
            this.rougeToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.rougeToolStripMenuItem.Text = "Patient";
            this.rougeToolStripMenuItem.Click += new System.EventHandler(this.rougeToolStripMenuItem_Click);
            // 
            // medecinToolStripMenuItem
            // 
            this.medecinToolStripMenuItem.Name = "medecinToolStripMenuItem";
            this.medecinToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.medecinToolStripMenuItem.Text = "Medecin";
            this.medecinToolStripMenuItem.Click += new System.EventHandler(this.medecinToolStripMenuItem_Click);
            // 
            // rendezvousToolStripMenuItem
            // 
            this.rendezvousToolStripMenuItem.Name = "rendezvousToolStripMenuItem";
            this.rendezvousToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.rendezvousToolStripMenuItem.Text = "Rendez-vous";
            this.rendezvousToolStripMenuItem.Click += new System.EventHandler(this.rendezvousToolStripMenuItem_Click);
            // 
            // soinToolStripMenuItem
            // 
            this.soinToolStripMenuItem.Name = "soinToolStripMenuItem";
            this.soinToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.soinToolStripMenuItem.Text = "Soin";
            this.soinToolStripMenuItem.Click += new System.EventHandler(this.soinToolStripMenuItem_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(844, 0);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(158, 37);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 644);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMDI";
            this.Text = "GESTION DE RENDEZ-VOUS MEDICAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rougeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soinToolStripMenuItem;
        private System.Windows.Forms.Button btnQuitter;
    }
}
