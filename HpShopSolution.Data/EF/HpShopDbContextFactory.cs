using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HpShopSolution.Data.EF
{
    public class HpShopDbContextFactory : IDesignTimeDbContextFactory<HpShopDbContext>
    {
        public HpShopDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("HpShopSolutionDb");
            var optionsBuilder = new DbContextOptionsBuilder<HpShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HpShopDbContext(optionsBuilder.Options);
        }
    }
}
