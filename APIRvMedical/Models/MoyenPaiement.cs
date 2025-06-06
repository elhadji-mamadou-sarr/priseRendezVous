using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical.Models
{
    public class MoyenPaiement
    {
        [Key]
        public int IdPaiement { get; set; }

        public DateTime datePaiement { get; set; }

        [MaxLength(10)]
        public string Statut { get; set; }

        public float montant { get; set; }

        public int? IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public Patient Patient { get; set; }

        public int? IdMedecin { get; set; }
        [ForeignKey("IdMedecin")]
        public Medecin Medecin { get; set; }


    }
}
