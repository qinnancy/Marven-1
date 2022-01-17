using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppHomepageInformation
    {
        public AppHomepageInformation()
        {
            AppHomepageInformationDetail = new HashSet<AppHomepageInformationDetail>();
        }

        public int Id { get; set; }
        public string HomepageIndicator { get; set; }
        public int HomepageProjectId { get; set; }
        public string HomepageIndicatorCity { get; set; }
        public string HomepageIndicatorContrast { get; set; }

        public virtual ICollection<AppHomepageInformationDetail> AppHomepageInformationDetail { get; set; }
    }
}
