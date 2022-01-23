using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppUserPreference
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PrefType { get; set; }
        public string PrefValue { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual AppUser User { get; set; }
    }
}
