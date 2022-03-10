using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace REAccess.Mobile.Common.ViewModel
{
    public class LogModel
    {
        [SwaggerSchema("当前页面")]
        public string PageName { get; set; }
        [SwaggerSchema("上一个页面")]
        public string PreviousPage { get; set; }
    }
}
