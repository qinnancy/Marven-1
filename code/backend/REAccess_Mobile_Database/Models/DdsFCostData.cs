using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DdsFCostData
    {
        public int DistrictSk { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string RegionalLevel { get; set; }
        public string TimeGranularity { get; set; }
        public string DataPeriod { get; set; }
        public decimal? RelativeLabourCost { get; set; }
        public decimal? OrginaryLabourSalary { get; set; }
        public decimal? IndustrialElectricityPrice { get; set; }
        public decimal? IndustrialWaterPrice { get; set; }
        public decimal? IndustrialGasPrice { get; set; }
        public decimal? IndustrialHeatPrice { get; set; }
        public decimal? AverageCommercialLandArea { get; set; }
        public decimal? AverageCommercialLandPrice { get; set; }
        public decimal? AverageCommercialRentArea { get; set; }
        public decimal? AverageCommercialRentRate { get; set; }
        public decimal? AverageIndustrialLandArea { get; set; }
        public decimal? AverageIndustrialLandPrice { get; set; }
        public decimal? AverageIndustrialRentArea { get; set; }
        public decimal? AverageIndustrialRentRate { get; set; }
        public int Id { get; set; }
    }
}
