﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Titula
    {
        [Key]
        public int TitulaID { get; set; }

        public string Naziv { get; set; }
    }
}
