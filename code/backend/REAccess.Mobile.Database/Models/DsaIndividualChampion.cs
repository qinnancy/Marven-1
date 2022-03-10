using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaIndividualChampion
    {
        public string Name { get; set; }
        public string Batch { get; set; }
        public long? CollectedYear { get; set; }
        public string ProvCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string Location { get; set; }
        public string SecondaryIndustryKey { get; set; }
        public string MainProduct { get; set; }
        public string Dlist { get; set; }
        public string Website { get; set; }
        public long? MainIndustryKey { get; set; }
        public long? Id { get; set; }
    }
}
