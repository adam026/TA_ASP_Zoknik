using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TA_ASP_Zoknik.Models
{
    [Table("Kolcsonzok")]
    public class Kolcsonzo
    {
        [Key, Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "A név megadása kötelező!")]
        public string Nev { get; set; }

        [Required(ErrorMessage = "Az e-mail cím megadása kötelező!")]
        [EmailAddress(ErrorMessage = "Az e-mail cím formátuma nem megfelelő!")]
        public string Email { get; set; }

        public int NoKolcsonzes { get; set; }
    }
}