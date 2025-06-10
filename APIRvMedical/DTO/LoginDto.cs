using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIRvMedical.DTO
{
    public class LoginDto
    {
        public string Identifiant { get; set; }
        public string MotDePasse { get; set; } 
    }
}