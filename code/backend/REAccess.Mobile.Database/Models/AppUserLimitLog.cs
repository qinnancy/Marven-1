using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppUserLimitLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string FunctionName { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}
