using CsvHelper.Configuration.Attributes;

namespace ConsoleGUS.Models
{
    public class TercModel
    {
        [Name("WOJ")]
        public string WOJ { get; set; }
        [Name("POW")]
        public string POW { get; set; }
        [Name("GMI")]
        public string GMI { get; set; }
        [Name("RODZ")]
        public string RODZ { get; set; }
        [Name("NAZWA")]
        public string NAZWA { get; set; }
        [Name("NAZWA_DOD")]
        public string NAZWA_DOD { get; set; }
        [Name("STAN_NA")]
        public string STAN_NA { get; set; }

    }
}
