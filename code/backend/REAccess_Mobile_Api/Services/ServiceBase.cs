using Microsoft.Extensions.Configuration;
using REAccess_Mobile_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REAccess_Mobile_Api.Services
{
    public class ServiceBase
    {
        protected readonly DatabaseContext _db;
        public ServiceBase()
        {
            var Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var sqlServerDb = Configuration.GetSection("SqlServerDb").Value;
            _db = new DatabaseContext(sqlServerDb);
        }
    }
}
