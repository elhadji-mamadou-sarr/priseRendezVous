using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priseRendezVous
{
    internal class Personne
    {
        [Key]
        public int idU { get; set; }

        [Required, MaxLength(200)]
        public string NomPrenom { get; set; }

        [Required, MaxLength(50)]
        public string Tel { get; set; }

        [Required, MaxLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(200)]
        public string Adresse { get; set; }

        
        
    }


}
