using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierRvMedical.Model
{
    public class Patient : Personne
    {

        [Required, MaxLength(3)]
        public string GroupeSanguin { get; set; }

        [Required]
        public float? Poids { get; set; }

        public virtual ICollection<Soin> Soins { get; set; }

        public virtual ICollection<RendezVous> RendezVous { get; set; }

    }
}
