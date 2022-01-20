using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppHomepageInformationDetail
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int HomepageId { get; set; }
        public string ContrastCity1 { get; set; }
        public string ContrastCity2 { get; set; }

        public virtual AppHomepageInformation Homepage { get; set; }
    }
}
