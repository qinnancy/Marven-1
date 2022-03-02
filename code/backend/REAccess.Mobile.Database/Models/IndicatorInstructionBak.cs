using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class IndicatorInstructionBak
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public int? Class1Id { get; set; }
        public int? Class2Id { get; set; }
        public string Description { get; set; }
        public string Formula { get; set; }
        public string DataSource { get; set; }
        public string ComentsUpdateDate { get; set; }
        public string ComentsRemarks { get; set; }
        public string Valid { get; set; }
        public string UnderlyingDataUnit { get; set; }
        public string DisplayDataUnit { get; set; }
        public int? RankForIndicator { get; set; }
        public int? NumberOfDecimalPlaces { get; set; }
        public string RankingRules { get; set; }
        public string MinimumDisplayDecimal { get; set; }
    }
}
