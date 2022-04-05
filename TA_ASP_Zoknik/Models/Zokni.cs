using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TA_ASP_Zoknik.Models
{
    [Table("Zoknik")]
    public class Zokni
    {
        [Key, Required]
        public int Id { get; set; }
        public string Tipus { get; set; }
        public int Keszlet { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public string Kep { get; set; }
    }
}