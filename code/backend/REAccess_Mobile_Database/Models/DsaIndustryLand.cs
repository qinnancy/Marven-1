using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaIndustryLand
    {
        public int Id { get; set; }
        public long? DistrictSk { get; set; }
        public string LandName { get; set; }
        public string LandIndex { get; set; }
        public string LandUse { get; set; }
        public decimal? LandTotalArea { get; set; }
        public decimal? LandPlanningArea { get; set; }
        public DateTime? LandClosingTime { get; set; }
        public string BuyerName { get; set; }
        public decimal? LandPrice { get; set; }
        public decimal? LandFloorPrice { get; set; }
        public decimal? LandUnitPrice { get; set; }
        public string BuyerCity { get; set; }
        public string BuyerDistrict { get; set; }
        public string BuyerIndustryPrimaryClassKey { get; set; }
        public string BuyerIndustrySecondaryClassKey { get; set; }
        public string BuyerBusiness { get; set; }
        public long? CitySk { get; set; }
        public string LandLocation { get; set; }
        public int ProvinceSk { get; set; }
    }
}
