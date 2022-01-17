using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DdsFTransit
    {
        public int DistrictSk { get; set; }
        public string DataPeriod { get; set; }
        public string TimeGranularity { get; set; }
        public string RegionalLevel { get; set; }
        public string NearestAirport { get; set; }
        public double? NearestAirportDrivingTime { get; set; }
        public string NearestRailwayStation { get; set; }
        public double? NearestRailwayStationDrivingTime { get; set; }
        public int? HighwayEntriesCount { get; set; }
        public int? LogisticsStationCount { get; set; }
        public int? RailwaySpecialClassCount { get; set; }
        public int? RailwayFirstClassCount { get; set; }
        public int? RailwaySecondClassCount { get; set; }
        public int? AirlineYearlyTakeoffLandingTimes { get; set; }
        public int? TrainYearlyDepartTimes { get; set; }
        public int? BusYearlyDepartTimes { get; set; }
        public int Id { get; set; }
    }
}
