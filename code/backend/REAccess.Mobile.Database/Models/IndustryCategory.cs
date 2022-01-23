using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class IndustryCategory
    {
        public int Id { get; set; }
        public string IndustryName { get; set; }
        public byte? Class { get; set; }
        public int? Class1Id { get; set; }
        public string IsValid { get; set; }
        public int? IndustryOrder { get; set; }
    }
}
