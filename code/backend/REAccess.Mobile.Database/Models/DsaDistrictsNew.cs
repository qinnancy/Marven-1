using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaDistrictsNew
    {
        public long? Id { get; set; }
        public int CountryCode { get; set; }
        public long? DistrictSk { get; set; }
        public string Prov { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public long? RankOfProvinces { get; set; }
        public long? RankOfCities { get; set; }
        public long? RankOfDistricts { get; set; }
    }
}
