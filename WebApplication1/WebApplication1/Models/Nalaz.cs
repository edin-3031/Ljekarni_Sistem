using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Nalaz
    {
        [Key]
        public int NalazID { get; set; }

        public string Opis { get; set; }
        public DateTime Datum_Vrijeme_Kreiranja { get; set; }

        public Prijem prijem { get; set; }
        [ForeignKey("prijem")]
        public int prijem_FK { get; set; }
    }
}
