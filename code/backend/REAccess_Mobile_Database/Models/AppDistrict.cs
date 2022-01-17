using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppDistrict
    {
        public long Id { get; set; }
        public string ProvId { get; set; }
        public string ProvName { get; set; }
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
    }
}
