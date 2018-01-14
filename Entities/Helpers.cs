using System;
using System.Collections;
using System.Configuration;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System.IO;

namespace MyWebAPI.Entities 
{
    public class Helpers
    {
        private static IConfigurationRoot _config;

        public static IConfigurationRoot Configuration 
        { 
            get 
            {
                if(_config == null)
                {
                    var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");

                    _config = builder.Build();
                }

                return _config;
            } 
            set { _config = value; } 
        }

        public static string GetRDSConnectionString()
        {
            var host = Configuration["AWS_RDS:HOSTNAME"];
            var dbName = Configuration["AWS_RDS:DB_NAME"];
            var username = Configuration["AWS_RDS:USERNAME"];
            var password = Configuration["AWS_RDS:PASSWORD"];
            
            return $"Data Source={host};Initial Catalog={dbName};User ID={username};Password={password}";
        }
    }
} 