using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppRankingListDetail
    {
        public int Id { get; set; }
        public int RankingListId { get; set; }
        public int IndicatorClass3Id { get; set; }
        public decimal? IndicatorWeight { get; set; }
        public string IndicatorDisplay { get; set; }

        public virtual IndicatorInstruction IndicatorClass3 { get; set; }
        public virtual AppRankingList RankingList { get; set; }
    }
}
