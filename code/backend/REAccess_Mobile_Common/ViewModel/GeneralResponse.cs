using System;
using System.Collections.Generic;
using System.Text;

namespace REAccess_Mobile_Common.ViewModel
{
    public class GeneralResponse
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public object ReturnObj { get; set; }
    }
}
