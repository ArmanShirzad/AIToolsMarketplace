using AIToolsMarketplace.Models;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetRecentOrdersAsync(int userId, int count);
    }

}
