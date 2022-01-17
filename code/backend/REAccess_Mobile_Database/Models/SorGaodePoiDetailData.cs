using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class SorGaodePoiDetailData
    {
        public string SearchKeywords { get; set; }
        public string SearchPoiTypeCode { get; set; }
        public string PotentialPoiCount { get; set; }
        public string PoiId { get; set; }
        public string PoiName { get; set; }
        public string ParentCode { get; set; }
        public string ParentName { get; set; }
        public string AdCode { get; set; }
        public string AdName { get; set; }
        public string GridCode { get; set; }
        public string BusinessArea { get; set; }
        public string PoiTypeCode { get; set; }
        public string PoiType { get; set; }
        public string PoiAddress { get; set; }
        public string Tel { get; set; }
        public string LocationCoords { get; set; }
        public string IndicatorType { get; set; }
    }
}
