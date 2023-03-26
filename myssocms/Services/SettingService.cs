using Microsoft.Extensions.Configuration;
using ServiceStack.OrmLite;
using System;
using System.IO;

namespace myssocms.Services
{
    public class SettingService
    {
        public static IConfigurationRoot Configuration;

        public static string GetConnectionString(string server)
        {
            DateTime time = DateTime.Now;
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            return Configuration[server];
        }

        protected OrmLiteConnectionFactory _connectionData;

        public SettingService()
        {
            OrmLiteConfig.DialectProvider = MySqlDialect.Provider;
            _connectionData = new OrmLiteConnectionFactory(GetConnectionString("server"),OrmLiteConfig.DialectProvider);
        }

        
    }
}
