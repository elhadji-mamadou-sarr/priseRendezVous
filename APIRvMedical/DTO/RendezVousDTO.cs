using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIRvMedical.DTO
{
    public class RendezVousDTO
    {
        public int IdRv { get; set; }
        public DateTime DateRv { get; set; }
        public string Statut { get; set; }
        public int IdPatient { get; set; }
        public int IdMedecin { get; set; }


        public int IdSoin { get; set; }
    }
}