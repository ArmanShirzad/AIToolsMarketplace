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
        public async Task<IEnumerable<Product>> GetProductsAsync(int count)
        {

            return await _context.Products.OrderByDescending(p => p.Reviews.Count)
                                            .Take(count)
                                            .ToListAsync();
        }

    }
}
