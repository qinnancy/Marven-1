using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppHomepageCityRankingDetail
    {
        public int Id { get; set; }
        public int CityRankingId { get; set; }
        public string IndicatorName { get; set; }
        public string IndicatorPlace { get; set; }
        public int DispalyOrder { get; set; }

        public virtual AppHomepageCityRanking CityRanking { get; set; }
    }
}
