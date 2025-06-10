using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierRendMedical.Model
{
    public class Role {

        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string code { get; set; }

        [MaxLength(200)]
        public string libelle { get; set; }
    
    }
}
