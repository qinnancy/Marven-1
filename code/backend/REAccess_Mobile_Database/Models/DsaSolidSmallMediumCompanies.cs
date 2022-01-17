using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaSolidSmallMediumCompanies
    {
        public string Name { get; set; }
        public string Batch { get; set; }
        public int ProvinceSk { get; set; }
        public int? CitySk { get; set; }
        public int? DistrictSk { get; set; }
        public string Location { get; set; }
        public string PrimaryIndustryKey { get; set; }
        public string SecondaryIndustryKey { get; set; }
        public string PrimaryProducts { get; set; }
        public int? Year { get; set; }
        public int Id { get; set; }
    }
}
