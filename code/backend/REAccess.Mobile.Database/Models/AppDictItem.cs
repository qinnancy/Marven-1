using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppDictItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public long AppDictGroupId { get; set; }

        public virtual AppDictGroup AppDictGroup { get; set; }
    }
}
