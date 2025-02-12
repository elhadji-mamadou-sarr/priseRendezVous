using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priseRendezVous.Model
{
    internal class Secretaire: Personne
    {

        [MaxLength(20)]
        public string TelephoneFixe { get; set; }


    }
}
