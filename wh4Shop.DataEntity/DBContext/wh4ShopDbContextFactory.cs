namespace wh4Shop.DataEntity.DBContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    public class wh4ShopDbContextFactory : IDesignTimeDbContextFactory<wh4ShopDbContext>
    {
        public wh4ShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                //.SetBasePath(Directory.GetCurrentDirectory())
                //.AddJsonFile("appsettings.config")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<wh4ShopDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=wh4shop;Username=postgres;Password=c0nc0b3b3");

            return new wh4ShopDbContext(optionsBuilder.Options);
        }
    }
}
