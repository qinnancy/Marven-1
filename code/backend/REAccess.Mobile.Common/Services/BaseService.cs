#region Using
using REAccess.Mobile.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Services
{
    public class BaseService
    {
        public readonly DatabaseContext _db;
        public BaseService()
        {
            _db = new DatabaseContext();
        }
    }
}
