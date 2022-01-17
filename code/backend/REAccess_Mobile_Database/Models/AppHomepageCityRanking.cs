using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppHomepageCityRanking
    {
        public AppHomepageCityRanking()
        {
            AppHomepageCityRankingDetail = new HashSet<AppHomepageCityRankingDetail>();
        }

        public int Id { get; set; }
        public string CityName { get; set; }
        public string Isvalid { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<AppHomepageCityRankingDetail> AppHomepageCityRankingDetail { get; set; }
    }
}
