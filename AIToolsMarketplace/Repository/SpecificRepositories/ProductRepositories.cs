using AIToolsMarketplace.Data;
using AIToolsMarketplace.Models;

using Microsoft.EntityFrameworkCore;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MarketDbContext context) : base(context)
        {

        }

        public IQueryable<Product> GetQueryable()
        {
            return _context.Set<Product>().AsQueryable();
        }

        public void UpdateProduct(Product product) 
        {
            _context.Products.Update(product);
        }


    }
}
