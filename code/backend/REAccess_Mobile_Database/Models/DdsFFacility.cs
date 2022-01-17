using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DdsFFacility
    {
        public int DistrictSk { get; set; }
        public string DataPeriod { get; set; }
        public string TimeGranularity { get; set; }
        public string RegionalLevel { get; set; }
        public int? RailwayStationCount { get; set; }
        public int? K12Count { get; set; }
        public int? InternationalSchoolCount { get; set; }
        public int? HotelCount { get; set; }
        public int? CinemaCount { get; set; }
        public int? SupermarketCount { get; set; }
        public int? StoreCount { get; set; }
        public int? StarbucksCount { get; set; }
        public int? MuseumCount { get; set; }
        public int? LibraryCount { get; set; }
        public int? ArtGalleryCount { get; set; }
        public int? TheaterCount { get; set; }
        public int? ScenicSpotCount { get; set; }
        public double? AvgRent { get; set; }
        public double? AvgHousePrice { get; set; }
        public int? HospitalBedsCount { get; set; }
        public int? HospitalCount { get; set; }
        public decimal? GreenCoverageRatioPercentage { get; set; }
        public decimal? GreenCoverageRatioHectare { get; set; }
        public decimal? AirQuality { get; set; }
        public int Id { get; set; }
    }
}
