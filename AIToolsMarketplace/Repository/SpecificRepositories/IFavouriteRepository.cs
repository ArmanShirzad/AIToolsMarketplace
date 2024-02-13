using AIToolsMarketplace.Models;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public interface IFavouriteRepository : IRepository<Favourite>
    {
        Task<IEnumerable<Favourite>> GetFavouritesAsync(string userId);
    }

}
