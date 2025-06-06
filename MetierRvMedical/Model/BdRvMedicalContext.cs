using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierRvMedical.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class BdRvMedicalContext:DbContext
    {
        public BdRvMedicalContext() :base("dbRvMedicalContext")
        {
        }

        public DbSet<Personne> Personnes { get; set; } // DbSet pour l'entité Personne
        public DbSet<Patient> Patients { get; set; }
        
        public DbSet<Utilisateur> utilisateurs { get; set; }    

        public DbSet<Medecin> Medecins { get; set; }

        public DbSet<Secretaire> secretaires {  get; set; }

        public DbSet<Agenda> agendas { get; set; }

        public DbSet<RendezVous> rendezvous { get; set; }

        public DbSet<Soin> soins { get; set; }

        public DbSet<Role> roles { get; set; }

        public DbSet<Admin> Admins { get; set; }


    }


}
