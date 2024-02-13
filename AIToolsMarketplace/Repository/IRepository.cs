namespace AIToolsMarketplace.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T?>> GetAllAsync();
        Task AddAsync(T entity);
        void Remove(T entity); 
    }
}
