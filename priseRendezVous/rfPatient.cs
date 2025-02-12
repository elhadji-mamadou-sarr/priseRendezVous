using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using priseRendezVous.View;

namespace priseRendezVous
{
    public partial class rfPatient : Form
    {
        public rfPatient()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient patientForm = new frmPatient();
            patientForm.MdiParent = this;
            patientForm.Show();
            patientForm.WindowState = FormWindowState.Maximized;
        }
    }
}
