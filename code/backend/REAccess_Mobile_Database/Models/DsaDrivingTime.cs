using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaDrivingTime
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string DistrictCenterCoords { get; set; }
        public string DestinationType { get; set; }
        public string DestinationName { get; set; }
        public string DestinationCoords { get; set; }
        public string DestinationAddress { get; set; }
        public double DrivingTimeSeconds { get; set; }
        public double DrivingTimeMinutes { get; set; }
        public int TaxiCost { get; set; }
        public int Distance { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
