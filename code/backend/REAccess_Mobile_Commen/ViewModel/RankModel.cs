using System;
using System.Collections.Generic;
using System.Text;

namespace REAccess_Mobile_Common.ViewModel
{
    public class SingleIndexModel
    {
        public string Unit { get; set; }
        public List<SingleIndex> SingleIndexList { get; set; }
    }
    public class SingleIndex
    {
        public int RankPlace { get; set; }
        public string CityName { get; set; }
        public string ProvinceName { get; set; }
        public string RankValue { get; set; }
    }
    public class CityRankModel
    {
        public string Year { get; set; }
        public List<CityRank> CityRankList { get; set; }
    }
    public class CityRank
    {
        public int RankPlace { get; set; }
        public string IndexName { get; set; }
        public string IndexScore { get; set; }
    }
}
