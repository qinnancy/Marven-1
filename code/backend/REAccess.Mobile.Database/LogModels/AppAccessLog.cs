using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.LogModels
{
    public partial class AppAccessLog
    {
        public long Id { get; set; }
        public int AccessUserId { get; set; }
        public long? AccessFunctionId { get; set; }
        public string RequestData { get; set; }
        public DateTime? AccessDate { get; set; }
        public DateTime? HeartbeatDate { get; set; }
        public string SessionId { get; set; }
        public string UserSource { get; set; }
    }
}
