using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierresTreats.Models
{
  public class PierresTreatsContextFactory : IDesignTimeDbContextFactory<ParisBakeryContext>
  {

    ParisBakeryContext IDesignTimeDbContextFactory<ParisBakeryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ParisBakeryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new ParisBakeryContext(builder.Options);
    }
  }
}