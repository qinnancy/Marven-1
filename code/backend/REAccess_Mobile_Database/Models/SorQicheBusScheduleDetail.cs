using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class SorQicheBusScheduleDetail
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DepartStation { get; set; }
        public string DestinationStation { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
    }
}
