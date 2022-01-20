using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaGdcInvestedCompanies
    {
        public int? InvestedCompanyKey { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string InvestedCompanyName { get; set; }
        public string Industry { get; set; }
        public string InvestedMonth { get; set; }
        public decimal? TotalInvestedAmount { get; set; }
    }
}
