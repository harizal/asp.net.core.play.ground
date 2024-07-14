using Microsoft.EntityFrameworkCore;
using Project.Core.Entities.Generals;

namespace Project.Infrastructure.Data
{
    public class ApplicationDbContextConfigurations
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}
