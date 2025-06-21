using DAL.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cannabis.Server.ContextFactory
{
    public class CannabisAccessoriesDbContextFactory : IDesignTimeDbContextFactory<CannabisAccessorriesDBContext>
    {
        public CannabisAccessorriesDBContext CreateDbContext(string[] args)
        {   //đọc cấu hình file trong config
            var configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();
            // Lấy connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Tạo DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<CannabisAccessorriesDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CannabisAccessorriesDBContext(optionsBuilder.Options);
           

        }
    }
}
