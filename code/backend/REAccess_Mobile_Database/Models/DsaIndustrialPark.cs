using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaIndustrialPark
    {
        public double? Id { get; set; }
        public string Code { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string ZoneType { get; set; }
        public string ZoneName { get; set; }
        public double? ApprovalDate { get; set; }
        public double? ApprovedArea { get; set; }
        public string LeadingIndustry { get; set; }
        public string ZoneLevel { get; set; }
    }
}
