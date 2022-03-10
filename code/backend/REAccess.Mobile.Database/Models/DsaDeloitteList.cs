using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaDeloitteList
    {
        public long? CollectedYear { get; set; }
        public string Dlist { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string ProvId { get; set; }
        public string CityId { get; set; }
        public string DistrictId { get; set; }
        public string Location { get; set; }
        public string SecondaryIndustryKey { get; set; }
        public string MainProduct { get; set; }
        public string Website { get; set; }
        public long? MainIndustryKey { get; set; }
        public long Id { get; set; }
    }
}
