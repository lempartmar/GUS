using CsvHelper.Configuration.Attributes;


namespace ConsoleGUS.Models
{
    public class SimcModel
    {
        [Name("WOJ")]
        public string WOJ { get; set; }
        [Name("POW")]
        public string POW { get; set; }
        [Name("GMI")]
        public string GMI { get; set; }
        [Name("RODZ_GMI")]
        public string RODZ { get; set; }

        [Name("RM")]
        public string RM { get; set; }

        [Name("MZ")]
        public string MZ { get; set; }

        [Name("NAZWA")]
        public string NAZWA { get; set; }

        [Name("SYM")]
        public string SYM { get; set; }

        [Name("SYMPOD")]
        public string SYMPOD { get; set; }

        [Name("STAN_NA")]
        public string STANNA { get; set; }

    }
}
