using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieChartBlazor.Data
{
    public class DataChart
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public int TotalVisits { get; set; } = 0;
        public int Rate { get; set; } = 0;
        public string RatePercentage => (this.Rate * 100) / this.TotalVisits + "%";

        public List<DataChart> GetDataCharts()
        {
            var dataCharts = new List<DataChart>();

            dataCharts.Add(new DataChart() { Id = 1, Name = "Chollas Lake", TotalVisits = 978, Rate = 429 });
            dataCharts.Add(new DataChart() { Id = 1, Name = "Balboa Park", TotalVisits = 978, Rate = 429 });
            dataCharts.Add(new DataChart() { Id = 1, Name = "Mission Bay Park", TotalVisits = 1778, Rate = 329 });
            dataCharts.Add(new DataChart() { Id = 1, Name = "Fiestas Island", TotalVisits = 7778, Rate = 801 });
            dataCharts.Add(new DataChart() { Id = 1, Name = "Mission Trails", TotalVisits = 455, Rate = 29 });


            return dataCharts;
        }

    }
}