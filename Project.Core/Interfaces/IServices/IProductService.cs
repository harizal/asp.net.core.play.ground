using Project.Core.Entities.Business;

namespace Project.Core.Interfaces.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();
        Task<ProductViewModel> GetProduct(int id);
        Task<bool> IsExists(string key, string value);
        Task<bool> IsExistsForUpdate(int id, string key, string value);
        Task<ProductViewModel> Create(ProductViewModel model);
        Task Update(ProductViewModel model);
        Task Delete(int id);
    }
}
