using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIRvMedical.DTO
{
    public class PatientDto
    {
        public string NomPrenom { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }

        public string GroupeSanguin { get; set; }
        public float Poids { get; set; }

    }
}