using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppHomepageCityContrast
    {
        public int Id { get; set; }
        public string ContrastIndicatorName { get; set; }
        public string ContrastCityOne { get; set; }
        public string ContrastCityOneData { get; set; }
        public string ContrastCityTwo { get; set; }
        public string ContrastCityTwoData { get; set; }
        public string Isvalid { get; set; }
        public int DisplayOrder { get; set; }
    }
}
