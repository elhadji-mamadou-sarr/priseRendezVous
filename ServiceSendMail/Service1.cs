using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace ServiceSendMail
{
    public partial class ServiceL3GLGroupes2 : ServiceBase
    {
        private static Timer aTimer;
        public ServiceL3GLGroupes2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += new ElapsedEventHandler(onTimedEvent);

            aTimer.Interval = 1000;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }
        protected override void OnStop()
        {
            aTimer.Stop();
            aTimer.Dispose();
            WriteLogSystem("Arret du service sendMail", string.Format("Le service a demarer a {0}", DateTime.Now));
        }

        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Send Mail: ";
                eventLog.WriteEntry(string.Format("date : {0}, libelle: {1}, description: {2}", DateTime.Now, libelle, erreur));
            }
        }
    

        private static void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                WriteLogSystem("test", DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
            }
            aTimer.Start();


        }
    }
}
