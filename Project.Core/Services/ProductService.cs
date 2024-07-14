using Project.Core.Entities.Business;
using Project.Core.Interfaces.IServices;

namespace Project.Core.Services
{
    public class ProductService : IProductService
    {
        public Task<ProductViewModel> Create(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExists(string key, string value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistsForUpdate(int id, string key, string value)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
