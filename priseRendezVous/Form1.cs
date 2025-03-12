using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGroupe2
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btneConnecter_Click(object sender, EventArgs e)
        {
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            // Personnalisation de la fenêtre
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Styliser les labels
            txtidentifiant.Font = new Font("Arial", 10, FontStyle.Bold);
            txtMotDePasse.Font = new Font("Arial", 10, FontStyle.Bold);

            // Styliser le champ utilisateur
            txtidentifiant.Font = new Font("Arial", 10);
            txtidentifiant.BorderStyle = BorderStyle.FixedSingle;

            // Styliser le champ mot de passe
            txtMotDePasse.Font = new Font("Arial", 10);
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.UseSystemPasswordChar = true;

            // Styliser le bouton
            btneConnecter.BackColor = Color.DarkBlue;
            btneConnecter.ForeColor = Color.White;
            btneConnecter.FlatStyle = FlatStyle.Flat;
            btneConnecter.Cursor = Cursors.Hand;
        }
    }
}
