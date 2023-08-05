using CruiseManagement.Api.Data;
using CruiseManagement.Api.Entities;
using CruiseManagement.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CruiseManagement.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CruiseManagementDbContext _cruiseManagementDbContext;

        public ProductRepository(CruiseManagementDbContext cruiseManagementDbContext)
        {
            this._cruiseManagementDbContext = cruiseManagementDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories  = await this._cruiseManagementDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await this._cruiseManagementDbContext.ProductCategories.FirstOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await this._cruiseManagementDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
           var products =  await this._cruiseManagementDbContext.Products.ToListAsync();
            return products;
        }
    }
}
