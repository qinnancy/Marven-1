#region
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.ViewModel
{
    public class SingleIndexModel
    {
        public string Unit { get; set; }
        public string Year { get; set; }
        public string IndexName { get; set; }
        public List<RankModel> SingleIndexList { get; set; }
    }
    public class RankModel
    {
        public int DistrictSk { get; set; }
        public int RankPlace { get; set; }
        public string CityName { get; set; }
        public string ProvinceName { get; set; }
        public string RankValue { get; set; }
        public string Unit { get; set; }
    }
    public class CityRankModel
    {
        public string Year { get; set; }
        public List<CityRank> CityRankList { get; set; }
    }
    public class CityRank
    {
        public int IndexId { get; set; }
        public int RankPlace { get; set; }
        public string IndexName { get; set; }
        public string IndexValue { get; set; }
        public string Unit { get; set; }
        public string Year { get; set; }
        public string CityName { get; set; }
    }
}
