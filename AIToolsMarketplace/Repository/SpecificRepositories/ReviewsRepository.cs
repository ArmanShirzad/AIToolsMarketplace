using AIToolsMarketplace.Data;
using AIToolsMarketplace.Models;

using Microsoft.EntityFrameworkCore;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public class ReviewsRepository : Repository<Reviews>, IReviewsRepository
    {
        public ReviewsRepository(MarketDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Reviews>> GetReviewssAsync(int productId)
        {
            return await _context.Reviews
                      .Where(r => r.ProductId == productId)
                      .ToListAsync();

        }
    }
}
