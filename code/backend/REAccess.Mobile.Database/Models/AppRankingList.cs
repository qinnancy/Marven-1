using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppRankingList
    {
        public AppRankingList()
        {
            AppRankingListDetail = new HashSet<AppRankingListDetail>();
        }

        public int Id { get; set; }
        public string ListName { get; set; }
        public string ListType { get; set; }
        public string ListDesc { get; set; }
        public int? ListOwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ListDisplayOrder { get; set; }
        public string Algorithm { get; set; }

        public virtual AppUser ListOwner { get; set; }
        public virtual ICollection<AppRankingListDetail> AppRankingListDetail { get; set; }
    }
}
