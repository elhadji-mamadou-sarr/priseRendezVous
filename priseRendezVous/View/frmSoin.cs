using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using priseRendezVous.Model;

namespace priseRendezVous.View
{
    public partial class frmSoin : Form
    {
        public frmSoin()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSoin_Load);
        }

        BdRvMedicalContext db = new BdRvMedicalContext();

        private void frmSoin_Load(object sender, EventArgs e)
        {

            ResetForm();
            dgSoin.DataSource = db.soins.ToList();
        }

        public void ResetForm()
        {
            txtLibelle.Text = string.Empty;
            txtCout.Text = string.Empty;

            dgSoin.DataSource = db.soins.ToList();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Soin s = new Soin();

            s.libelle = txtLibelle.Text;
            s.cout = float.Parse(txtCout.Text);
            db.soins.Add(s);
            db.SaveChanges();
            ResetForm();
        }

        private void bntModifier_Click(object sender, EventArgs e)
        {

            int? id = int.Parse(dgSoin.CurrentRow.Cells[0].Value.ToString());
            if (id.HasValue)
            {
                var s = db.soins.Find(id);

                s.libelle = txtLibelle.Text;
                s.cout = float.Parse(txtCout.Text);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = dgSoin.CurrentRow.Cells[1].Value.ToString();
            txtCout.Text = dgSoin.CurrentRow.Cells[2].Value.ToString();
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSoin.CurrentRow.Cells[0].Value.ToString());
            if (id.HasValue)
            {
                var s = db.soins.Find(id);
                db.soins.Remove(s);
                ResetForm();
                db.SaveChanges();
            }
        }
    }
}
