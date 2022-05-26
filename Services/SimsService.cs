using ConsoleGUS.Models;
using ConsoleGUS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGUS.Services
{
    public class SimsService
    {
        public static List<ShortSimsModel> listaKodowSims;
        public static List<ShortSimsModel> getSimsDataService()
        {

            listaKodowSims = new List<ShortSimsModel>();

            foreach (var item in SimcRepository.GetDataSimc())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item.WOJ.Length == 1 ? ("0" + item.WOJ) : item.WOJ);
                sb.Append(item.POW.Length == 1 ? ("0" + item.POW) : item.POW);
                sb.Append(item.GMI.Length == 1 ? ("0" + item.GMI) : item.GMI);
                sb.Append(item.RODZ);
                listaKodowSims.Add(new ShortSimsModel(item.NAZWA, sb.ToString()));
            }

            return listaKodowSims;
        }
    }
}
