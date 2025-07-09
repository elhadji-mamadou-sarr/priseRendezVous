using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priseRendezVous.Model
{
    internal class Medecin : Personne
    {

        [MaxLength(100)]
        public string Specialite { get; set; }

        [MaxLength(20)]
        public string NumeroOrdre { get; set; }

        public virtual ICollection<Agenda> Agenda { get; set; }

    } 
   }
