using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaIfindLandSales
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string LandName { get; set; }
        public string PlannedUsage { get; set; }
        public string ConstructionArea { get; set; }
        public string BuildingArea { get; set; }
        public string SalesType { get; set; }
        public string LandAddress { get; set; }
        public string TotalLandArea { get; set; }
        public string BidStartPrice { get; set; }
        public string BidFinalPrice { get; set; }
        public string BidEndTime { get; set; }
        public string BidStatus { get; set; }
    }
}
