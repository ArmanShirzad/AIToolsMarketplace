﻿using AIToolsMarketplace.Data;

using Microsoft.EntityFrameworkCore;

namespace AIToolsMarketplace.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MarketDbContext _context;

        public Repository(MarketDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<IEnumerable<T?>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();

        }

 

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

    }
}
