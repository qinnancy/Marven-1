using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppUserLoginSession
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string SessionId { get; set; }
        public DateTime? AccessDate { get; set; }
        public string IsValid { get; set; }
    }
}
