using ConsoleGUS.Models;
using ConsoleGUS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGUS.Services
{
    public class StreetService { 

    public static List<ShortStreetModel> listaKodowStreet;
    public static List<ShortStreetModel> getStreetDataService()
    {

        listaKodowStreet = new List<ShortStreetModel>();

        foreach (var item in StreetRepository.GetDataStreet())
        {
            listaKodowStreet.Add(new ShortStreetModel(item.SYM, item.NAZWA_1, item.CECHA));
        }
        return listaKodowStreet;
    }
}
}
