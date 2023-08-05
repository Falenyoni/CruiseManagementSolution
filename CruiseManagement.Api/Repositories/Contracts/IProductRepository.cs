using CruiseManagement.Api.Entities;

namespace CruiseManagement.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<Product> GetItem(int id);
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<ProductCategory> GetCategory(int id);
    }
}
