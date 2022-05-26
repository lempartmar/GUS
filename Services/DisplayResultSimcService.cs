using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGUS.Services
{
    public class DisplayResultSimcService
    {
        public static int DisplaySImc(string data)
        {
            var result2 = from c in SimsService.getSimsDataService()
                          where c.KOD == data
                          select c;

            foreach (var item in result2)
            {
                Console.WriteLine("Nazwa miejscowosci: " + item.Nazwa);
            }
            return result2.Equals(null) ? 0 : 1;
        }
    }
}
