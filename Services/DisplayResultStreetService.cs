using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGUS.Services
{
    public class DisplayResultStreetService
    {
        public static void DisplayStreet(string data)
        {
            var result2 = from c in StreetService.getStreetDataService()
                          where c.Symbol == data
                          select c;

            foreach (var item in result2)
            {
                Console.WriteLine("Nazwa ulicy: " + item.Nazwa_1  + "Nazwa cechy: " + item.Cecha);
            }
        }
    }
}


