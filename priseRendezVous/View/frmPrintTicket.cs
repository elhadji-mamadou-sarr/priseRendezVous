using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppGroupe2.Model;
using AppGroupe2.Report;
//using RestSharp;

namespace AppGroupe2.View
{
    public partial class frmPrintTicket : Form
    {
        private int _idRv;
        private BdRvMedicalContexe bd = new BdRvMedicalContexe();

        public frmPrintTicket(int idRv)
        {
            InitializeComponent();
            _idRv = idRv;
        }

        private void frmPrintTicket_Load(object sender, EventArgs e)
        {
            rptTicketRV objRpt = new rptTicketRV();
            objRpt.SetDataSource(GetTableTicket(_idRv));
            //crystalReportViewer1.ReportSource = objRpt;
            //crystalReportViewer1.Refresh();

            // Générer et envoyer le PDF via WhatsApp après le chargement du formulaire
            // EnvoyerTicketWhatsApp();
        }

        public DataTable GetTableTicket(int idRv)
        {
            DataTable table = new DataTable();
            table.Columns.Add("NomPrenom", typeof(string));
            table.Columns.Add("DateNaissance", typeof(DateTime));
            table.Columns.Add("DateRv", typeof(DateTime));
            table.Columns.Add("Medecin", typeof(string));
            table.Columns.Add("HeureRv", typeof(string));
            table.Columns.Add("DataQr", typeof(byte[]));

            var leRv = bd.RendezVous.FirstOrDefault(a => a.IdRv == idRv);
            if (leRv != null)
            {
                table.Rows.Add(leRv.patient.NomPrenom, leRv.patient.DateNaissance, leRv.DateRv, leRv.Medecin.NomPrenom, leRv.DateRv.ToString("HH:mm"), new byte[0]);
            }
            else
            {
                table.Rows.Add("NomPrenom", DateTime.Now, DateTime.Now, "NomPrenom", DateTime.Now.ToString("HH:mm"), new byte[0]);
            }
            return table;
        }

        public string ExportToPdf(int idRv)
        {
            try
            {
                rptTicketRV objRpt = new rptTicketRV();
                objRpt.SetDataSource(GetTableTicket(idRv));

                string filePath = Path.Combine(Path.GetTempPath(), $"Ticket_{idRv}.pdf");

                objRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, filePath);

                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation du PDF : " + ex.Message);
                return null;
            }
        }

        //public void SendPdfViaWhatsApp(string phoneNumber, string filePath)
        //{
        //    try
        //    {
        //        var client = new RestClient("https://api.wassenger.com/v1/messages");
        //        var request = new RestRequest("", Method.Post); // Correction ici

        //        request.AddHeader("Content-Type", "application/json");
        //        request.AddHeader("Token", "6daddb7d70832356cd3ca334e6316c2cee5b8e8bc06c4bfa0cb2ce1d3695564961b64b003e5044d9"); // Remplace par ta clé API

        //        // Implémentation temporaire d'UploadFileToCloud
        //        //string publicPdfUrl = GoogleDriveUploader.UploadFileToGoogleDrive(filePath);


        //        var requestBody = new
        //        {
        //            phone = phoneNumber,
        //            media = new
        //            {
        //                url = publicPdfUrl,
        //                expiration = "30d"
        //            }
        //        };

        //        request.AddJsonBody(requestBody);
        //        var response = client.Execute(request);

        //        if (response.IsSuccessful)
        //        {
        //            MessageBox.Show("Message envoyé avec succès !");
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Erreur : {response.StatusCode} - {response.Content}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur lors de l'envoi du message : " + ex.Message);
        //    }
        //}

        //private void EnvoyerTicketWhatsApp()
        //{
        //    string filePath = ExportToPdf(_idRv);
        //    if (!string.IsNullOrEmpty(filePath))
        //    {
        //        SendPdfViaWhatsApp("+221785676312", filePath); // Remplace par le vrai numéro
        //    }
        //}

        //private string UploadFileToCloud(string filePath)
        //{
        //    // Implémentation fictive : retourne une URL statique
        //    // Ici, tu devrais télécharger le fichier sur un service comme AWS S3, Firebase Storage, Google Drive, etc.
        //    return "https://example.com/path/to/uploaded/file.pdf";
        //}

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    EnvoyerTicketWhatsApp();
        //}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintTicket
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmPrintTicket";
            this.Load += new System.EventHandler(this.frmPrintTicket_Load_1);
            this.ResumeLayout(false);

        }

        private void frmPrintTicket_Load_1(object sender, EventArgs e)
        {

        }
    }
}
