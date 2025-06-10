using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierRendMedical.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class BdRvMedicalContext:DbContext
    {
        public BdRvMedicalContext() :base("dbRvMedicalContext")
        {
        }

        public DbSet<Personne> Personnes { get; set; } // DbSet pour l'entité Personne
        public DbSet<Patient> Patients { get; set; }
        
        public DbSet<Utilisateur> Utilisateurs { get; set; }    

        public DbSet<Medecin> Medecins { get; set; }

        public DbSet<Secretaire> Secretaires {  get; set; }

        public DbSet<Agenda> Agendas { get; set; }

        public DbSet<RendezVous> Rendezvous { get; set; }

        public DbSet<Soin> Soins { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Admin> Admins { get; set; }


    }


}
