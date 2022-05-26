using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using ConsoleGUS.Models;

namespace ConsoleGUS.Repository
{
        public class StreetRepository
        {
            public static List<StreetModel> GetDataStreet()
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                };
            string path = Path.Combine(Environment.CurrentDirectory);
            string pathFinal = path.Remove(path.Length - 16);
            var streamReader = new StreamReader(pathFinal + @"Data\ULIC_2.csv");
                var csv = new CsvReader(streamReader, config);
                var records = csv.GetRecords<StreetModel>().ToList();

                return records;
            }
        }
    }

