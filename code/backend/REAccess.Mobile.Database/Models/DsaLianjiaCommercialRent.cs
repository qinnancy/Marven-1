using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaLianjiaCommercialRent
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string BizcircleName { get; set; }
        public string StreetName { get; set; }
        public string ResblockName { get; set; }
        public string PriceRange { get; set; }
        public int? ResultCount { get; set; }
        public string BuildingId { get; set; }
        public string HouseCode { get; set; }
        public string HousedelCode { get; set; }
        public string Title { get; set; }
        public decimal? Area { get; set; }
        public decimal? UnitRentPrice { get; set; }
        public decimal? UnitMonthRentPrice { get; set; }
        public decimal? RentPrice { get; set; }
        public decimal? Score { get; set; }
        public string FloorPosition { get; set; }
        public string Fitment { get; set; }
        public string Furniture { get; set; }
        public string HasMeetingRoom { get; set; }
        public string IsNearSubway { get; set; }
        public string SubwayDistance { get; set; }
        public string IsRegistered { get; set; }
        public string Tags { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
