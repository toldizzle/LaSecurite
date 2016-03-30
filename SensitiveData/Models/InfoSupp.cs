using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SensitiveData.Models
{
    public class InfoSupp
    {
        [Key]
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [Required, CreditCard]
        public string NumeroCarte { get; set; }
        public string Adresse { get; set; }
    }
}