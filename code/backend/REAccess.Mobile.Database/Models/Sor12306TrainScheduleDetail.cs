using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class Sor12306TrainScheduleDetail
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string TrainType { get; set; }
        public string StationName { get; set; }
        public string TrainCode { get; set; }
        public string Date { get; set; }
        public string DepartStationTime { get; set; }
        public string StartStation { get; set; }
        public string EndStation { get; set; }
    }
}
