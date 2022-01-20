using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class EmailLog
    {
        public int Id { get; set; }
        public string EmailType { get; set; }
        public string EmailToList { get; set; }
        public string EmailCcList { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public DateTime? EmailSentTime { get; set; }
    }
}
