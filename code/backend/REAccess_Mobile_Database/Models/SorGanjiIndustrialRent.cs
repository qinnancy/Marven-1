using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class SorGanjiIndustrialRent
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public decimal? AverageDayRentRate { get; set; }
        public decimal? AverageArea { get; set; }
        public decimal? AverageMonthRentRate { get; set; }
    }
}
