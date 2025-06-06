using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical.Models
{
    public class Agenda
    {

        [Key]
        public int IdAgenda {  get; set; }
        
        public DateTime DatePlanifie { get; set; }

        [MaxLength(200)]
        public string Titre { get; set; }

        [MaxLength(200)]
        public string DateDebut { get; set; }

        [MaxLength(200)]
        public string DateFin { get; set; }

        [MaxLength(10)]
        public string Creneau { get; set; }

        [MaxLength(200)]
        public string Lieu { get; set; }

        [MaxLength(10)]
        public string Statut { get; set; }

        public int? IdMedecin { get; set; }
        [ForeignKey("IdMedecin")]
        public Medecin Medecin { get; set; }

        [JsonIgnore]
        public virtual ICollection<RendezVous> RendezVous { get; set; }


    }


}
