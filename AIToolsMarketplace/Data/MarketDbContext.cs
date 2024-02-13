using AIToolsMarketplace.Models;

using Microsoft.EntityFrameworkCore;

namespace AIToolsMarketplace.Data
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
        {

        }
        
       public DbSet<Product> Products { get; set; }
       public DbSet<Order> Orders { get; set; }
       public DbSet<Reviews> Reviews { get; set; }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Favourite> Favourites { get; set; }
       public DbSet<FavouriteProducts> FavouriteProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
        
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FavouriteProducts>().HasKey(fp => new { fp.ProductId, fp.FavouriteId });
        }
    }
}
