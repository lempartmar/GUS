using ConsoleGUS.Models;
using ConsoleGUS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGUS.Services
{
    public class TercService
    {
        public static List<ShortTercModel> listaKodowTerc;
        public static List<ShortTercModel> getTercDataService()
        {

            listaKodowTerc = new List<ShortTercModel>();

            foreach (var item in TercRepository.GetDataTerc())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item.WOJ.Length == 1 ? ("0" + item.WOJ) : item.WOJ);
                sb.Append(item.POW.Length == 1 ? ("0" + item.POW) : item.POW);
                sb.Append(item.GMI.Length == 1 ? ("0" + item.GMI) : item.GMI);
                sb.Append(item.RODZ);
                listaKodowTerc.Add(new ShortTercModel(item.NAZWA, sb.ToString()));
            }

            return listaKodowTerc;
        }
    }
}
