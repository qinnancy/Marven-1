﻿using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaNationalHighTech
    {
        public string Name { get; set; }
        public long? CollectedYear { get; set; }
        public string Batch { get; set; }
        public string ProvCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string Location { get; set; }
        public long? MainIndustryKey { get; set; }
        public string SecondaryIndustryKey { get; set; }
        public long? Id { get; set; }
    }
}
