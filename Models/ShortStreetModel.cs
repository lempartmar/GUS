using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGUS.Models
{
    public class ShortStreetModel
    {
        public ShortStreetModel(string symbol, string nazwa_1, string cecha)
        {
            Symbol = symbol;
            Nazwa_1 = nazwa_1;
            Cecha = cecha;
        }

        public string Symbol { get; set; }
        public string Nazwa_1 { get; set; }
        public string Cecha { get; set; }
   
    }
}
