using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class PacijentPrikazVM
    {
        public int PacijentID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Spol spol { get; set; }
#nullable enable
        public string? Adresa { get; set; }
        public string? BrojTelefona { get; set; }
#nullable disable
    }

    public class lista_PacijentPrikazVM
    {
        public List<PacijentPrikazVM> lista { get; set; }
    }
}
