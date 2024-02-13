using AIToolsMarketplace.Models;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategorysAsync(int count);
    }

}
