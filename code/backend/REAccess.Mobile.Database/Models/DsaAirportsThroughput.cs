using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaAirportsThroughput
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string AirportName { get; set; }
        public string Year { get; set; }
        public int? PassengerThroughput { get; set; }
        public int? CargoThroughput { get; set; }
        public int? TakeoffLanding { get; set; }
    }
}
