using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaGanjiIndustrialRent
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string BusinessArea { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public decimal? DayRentRate { get; set; }
        public decimal? Area { get; set; }
        public string AreaUnit { get; set; }
        public decimal? MonthRentRate { get; set; }
    }
}
