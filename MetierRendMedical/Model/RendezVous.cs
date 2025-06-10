using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierRendMedical.Model
{
    public class RendezVous
    {
        [Key]
        public int IdRv { get; set; }

        public DateTime DateRv { get; set; }

        [MaxLength(20)]
        public string Statut { get; set; }

        public int? IdPatient{ get; set; }
        [ForeignKey("IdPatient")]
        public Patient Patient{ get; set; }

        public int? IdMedecin { get; set; }
        [ForeignKey("IdMedecin")]
        public Medecin Medecin { get; set; }

        public int? IdSoin { get; set; }
        [ForeignKey("IdSoin")]
        public Soin Soin { get; set; }
    }
}
