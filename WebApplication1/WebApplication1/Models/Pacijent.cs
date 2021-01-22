using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pacijent
    {
        [Key]
        public int PacijentID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public Spol spol { get; set; }
        [ForeignKey("spol")]
        public int spol_FK { get; set; }



#nullable enable
        public string? Adresa { get; set; }
        public string? BrojTelefona { get; set; }
    }
}
