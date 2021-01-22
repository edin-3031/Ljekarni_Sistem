using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Prijem
    {
        [Key]
        public int PrijemID { get; set; }

        public DateTime Datum_Vrijeme { get; set; }
        public bool Hitni_Prijem { get; set; }

        public Pacijent pacijent { get; set; }
        [ForeignKey("pacijent")]
        public int pacijent_FK { get; set; }

        public Ljekar ljekar{ get; set; }
        [ForeignKey("ljekar")]
        public int ljekar_FK { get; set; }
    }
}
