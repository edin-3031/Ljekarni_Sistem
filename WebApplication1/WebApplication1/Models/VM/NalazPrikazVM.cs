using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class NalazPrikazVM
    {
        public int nalazId { get; set; }
        public Pacijent pacijent { get; set; }
        public string opis { get; set; }
        public DateTime datum_reiranja { get; set; }
        public Prijem prijem { get; set; }
    }
}
