using AIToolsMarketplace.Data;
using AIToolsMarketplace.Models;

using Microsoft.EntityFrameworkCore;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(MarketDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetCategorysAsync(int count)
        {
            return await _context.Categories
                            .Include(c => c.Products)
                            .ToListAsync();
        }
    }
}
