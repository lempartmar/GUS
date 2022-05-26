using CsvHelper.Configuration.Attributes;

namespace ConsoleGUS.Models
{
public class StreetModel
    {
        [Name("WOJ")]
        public string WOJ { get; set; }
        [Name("POW")]
        public string POW { get; set; }
        [Name("GMI")]
        public string GMI { get; set; }
        [Name("RODZ_GMI")]
        public string RODZ_GMI { get; set; }
        [Name("SYM")]
        public string SYM { get; set; }
        [Name("SYM_UL")]
        public string SYM_UL { get; set; }
        [Name("CECHA")]
        public string CECHA { get; set; }
        [Name("NAZWA_1")]
        public string NAZWA_1 { get; set; }
        [Name("NAZWA_2")]
        public string NAZWA_2 { get; set; }
        [Name("STAN_NA")]
        public string STAN_NA { get; set; }

    }
}
