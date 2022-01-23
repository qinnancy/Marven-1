using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class VcityParkList
    {
        public long Id { get; set; }
        public long? DistrictId { get; set; }
        public string ZoneClass { get; set; }
        public string ZoneType { get; set; }
        public string ZoneName { get; set; }
        public string Prov { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string MainIndustry { get; set; }
        public long IndustryId { get; set; }
    }
}
