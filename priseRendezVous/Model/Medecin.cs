//using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGroupe2.Model
{
  
    public class Medecin: Utilisateur
    {
        [Key]
        public string IdMedecin { get; set; }


        [MaxLength(20)]
        public string Specialite  {  get; set; }

        [MaxLength(10)]
        public string NumeroOrdre { get; set; }
       
        public virtual ICollection<Agenda> agenda { get; set;}
    }
}
