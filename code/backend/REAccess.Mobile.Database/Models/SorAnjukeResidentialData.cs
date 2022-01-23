using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class SorAnjukeResidentialData
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string MonthYyyymm { get; set; }
        public int? AveragePrice { get; set; }
        public int? AverageRent { get; set; }
    }
}
