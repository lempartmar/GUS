﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGUS.Models
{
    public class ShortTercModel
        
    {
        public ShortTercModel(string nazwa, string kOD)
        {
            Nazwa = nazwa;
            KOD = kOD;
        }

        public string Nazwa { get; set; }
        public string KOD { get; set; }

    }
}
