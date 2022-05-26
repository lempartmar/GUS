using CsvHelper;
using System.Globalization;
using System.Linq;
using System.IO;
using System;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Text;
using ConsoleGUS.Models;


namespace ConsoleGUS.Repository
{
    public class TercRepository
    {

        public static List<TercModel> GetDataTerc()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
            };
            string path = Path.Combine(Environment.CurrentDirectory);
            string pathFinal = path.Remove(path.Length - 16);
            var streamReader = new StreamReader(pathFinal + @"Data\TERC.csv");
            var csv = new CsvReader(streamReader, config);
            var records = csv.GetRecords<TercModel>().ToList();

            return records;
        }
    }
}
