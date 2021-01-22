using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Ljekar
    {
        [Key]
        public int LjekarID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Sifra { get; set; }

        public Titula titula { get; set; }
        [ForeignKey("titula")]
        public int titula_FK { get; set; }
    }
}
