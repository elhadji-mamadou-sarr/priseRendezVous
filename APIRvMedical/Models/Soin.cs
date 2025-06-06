using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIRvMedical.Models
{
    public class Soin
    {

        [Key]
        public int IdSoin { get; set; }

        [MaxLength(200)]
        public string libelle { get; set; }

        public float cout { get; set; }
    }
}