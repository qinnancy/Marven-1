using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppConfig
    {
        public int Id { get; set; }
        public string ConfigType { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
