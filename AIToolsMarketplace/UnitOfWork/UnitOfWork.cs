using AIToolsMarketplace.Data;
using AIToolsMarketplace.Repository.SpecificRepositories;

namespace AIToolsMarketplace.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketDbContext _context;
        public IProductRepository Products { get; private set; }
        public IOrderRepository Orders { get; private set; }

        public ICategoryRepository Categorys { get; private set; }

        public IReviewsRepository Reviews { get; private set; }

        public IFavouriteRepository Favourites { get; private set; }

        public UnitOfWork(MarketDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Categorys = new CategoryRepository(_context);
            Orders = new OrderRepository(_context);
            Favourites = new FavouriteRepository(_context);
            Reviews = new ReviewsRepository(_context);

        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();

        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
