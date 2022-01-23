using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsFGaodeDrivingTime
    {
        public int DistrictSk { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string DistrictCenterCoords { get; set; }
        public string DestinationType { get; set; }
        public string DestinationName { get; set; }
        public double DrivingTimeEstimation { get; set; }
        public int TaxiCostEstimation { get; set; }
        public int DistanceEstimation { get; set; }
        public int Id { get; set; }
    }
}
