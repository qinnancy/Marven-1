using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class SorIfindLandSales
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string UsageFilter { get; set; }
        public string Year { get; set; }
        public decimal? AverageLandArea { get; set; }
        public decimal? AverageBidFinalPrice { get; set; }
    }
}
