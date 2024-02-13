using AIToolsMarketplace.Models;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public interface IReviewsRepository : IRepository<Reviews>
    {
        Task<IEnumerable<Reviews>> GetReviewssAsync(int productId);
    }

}
