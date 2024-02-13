using AIToolsMarketplace.Data;
using AIToolsMarketplace.Models;

using Microsoft.EntityFrameworkCore;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public class FavouriteRepository : Repository<Favourite>, IFavouriteRepository
    {
        public FavouriteRepository(MarketDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Favourite>> GetFavouritesAsync(string userId)
        {
            return await _context.Favourites
                      .Where(f => f.UserId == userId)
                      .Include(f => f.Products) // Assuming a collection of Products in Favourite
                      .ToListAsync();
        }
    }
}
