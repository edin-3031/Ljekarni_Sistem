using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class pdfVM
    {
        public int prijemId { get; set; }
        public DateTime datumPrijema { get; set; }
        public string pacijent { get; set; }
        public string ljekar { get; set; }
        public bool hitno { get; set; }
#nullable enable
        public DateTime? datumNalaza { get; set; }
        public string? opis { get; set; }
#nullable disable
    }

    public class lista_pdfVM
    {
        public List<pdfVM> lista { get; set; }
    }
}
