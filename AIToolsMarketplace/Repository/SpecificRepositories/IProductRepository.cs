using AIToolsMarketplace.Models;

namespace AIToolsMarketplace.Repository.SpecificRepositories
{
    public interface IProductRepository : IRepository<Product>
    {
        void UpdateProduct(Product product);
       IQueryable<Product> GetQueryable();

    }

}
