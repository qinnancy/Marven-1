using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class IndicatorForDevelopTrend
    {
        public long Id { get; set; }
        public string IndicatorName { get; set; }
        public float? CategoryType { get; set; }
        public string Unit { get; set; }
        public long? Order { get; set; }
        public string Function { get; set; }
    }
}
