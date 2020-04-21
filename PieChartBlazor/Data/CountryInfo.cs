using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieChartBlazor.Data
{
    public class CountryInfo
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public int TotalCases { get; set; } = 0;
        public int TotalDeaths { get; set; } = 0;
        public string DeathPercentage => (this.TotalDeaths * 100) / this.TotalCases + "%";

        public List<CountryInfo> GetCountryInfos()
        {
            var countryInfos = new List<CountryInfo>();

            countryInfos.Add(new CountryInfo() { Id = 1, Name = "USA", TotalCases = 147778, TotalDeaths = 2429 });
            countryInfos.Add(new CountryInfo() { Id = 1, Name = "Ital", TotalCases = 47778, TotalDeaths = 10429 });
            countryInfos.Add(new CountryInfo() { Id = 1, Name = "China", TotalCases = 147778, TotalDeaths = 3329 });
            countryInfos.Add(new CountryInfo() { Id = 1, Name = "Spain", TotalCases = 147778, TotalDeaths = 6801 });
            countryInfos.Add(new CountryInfo() { Id = 1, Name = "Germany", TotalCases = 147778, TotalDeaths = 429 });
            countryInfos.Add(new CountryInfo() { Id = 1, Name = "France", TotalCases = 147778, TotalDeaths = 2000 });
            countryInfos.Add(new CountryInfo() { Id = 1, Name = "Iran", TotalCases = 147778, TotalDeaths = 2629 });

            return countryInfos;
        }

    }
}
