using AIToolsMarketplace.Repository.SpecificRepositories;

namespace AIToolsMarketplace.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        public IProductRepository  Products { get;  }
        public IOrderRepository Orders { get;  }
        public ICategoryRepository Categorys { get;  }
        public IReviewsRepository Reviews { get;  }
        public IFavouriteRepository Favourites { get;  }

        Task<int> CompleteAsync();
    }
}
