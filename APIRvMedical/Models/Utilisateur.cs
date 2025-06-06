using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical.Models
{
    public class Utilisateur:Personne
    {
        [MaxLength(20)]
        public string Identifiant { get; set; }

        [MaxLength(100)]
        public string MotDePasse { get; set; }

        public bool Statut { get; set; }

    }
}
