using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppFeedback
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public string IsProcessed { get; set; }
        public string ProcessedMessage { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public int? ProcessedBy { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyName { get; set; }

        public virtual AppUser User { get; set; }
    }
}
