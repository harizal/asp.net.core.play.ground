using Project.Core.Entities.Generals;
using Project.Core.Interfaces.IRepositories;
using Project.Infrastructure.Data;

namespace Project.Infrastructure.Repositories
{
    public class ProductRepository(ApplicationDbContext dbContext) : BaseRepository<Product>(dbContext), IProductRepository
    {
    }
}
