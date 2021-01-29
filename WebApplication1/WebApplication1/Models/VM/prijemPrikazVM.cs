using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class prijemPrikazVM
    {
        public int PrijemID { get; set; }

        public DateTime Datum_Vrijeme { get; set; }
        public bool Hitni_Prijem { get; set; }
        public Pacijent pacijent { get; set; }
        public Ljekar ljekar { get; set; }
    }

    public class lista_prijemPrikazVM
    {
        public List<prijemPrikazVM> lista { get; set; }
        public DateTime datumOD { get; set; }
        public DateTime datumDO { get; set; }
    }
}
