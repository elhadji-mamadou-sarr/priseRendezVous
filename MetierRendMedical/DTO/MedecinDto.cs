using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIRvMedical.DTO
{
    public class MedecinDto
    {
        public string NomPrenom { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Specialite { get; set; }
        public string NumeroOrdre { get; set; }
    }
}