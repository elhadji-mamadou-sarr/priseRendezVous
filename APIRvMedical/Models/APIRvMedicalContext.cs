using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIRvMedical.Models
{
    public class APIRvMedicalContext:DbContext
    {

        public APIRvMedicalContext() : base("APIRvMedicalContext")
        {
        }

        public DbSet<Soin> soins { get; set; }

        public DbSet<Personne> Personnes { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Medecin> Medecins { get; set; }

        public DbSet<Secretaire> Secretaires { get; set; }

        public DbSet<Agenda> Agendas { get; set; }

        public DbSet<RendezVous> Rendezvous { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}