using AIToolsMarketplace.Data;
using AIToolsMarketplace.Models;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public class OrderRepository : Repository<Order> , IOrderRepository
    {
        public OrderRepository(MarketDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Order>> GetRecentOrdersAsync(int userId, int count)
        {
            throw new NotImplementedException();
        }
    }
}
