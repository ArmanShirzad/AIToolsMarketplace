using System.ComponentModel.DataAnnotations;

namespace AIToolsMarketplace.Models
{
    // join 

    public class FavouriteProducts {

        [Key]
        public int FavouriteId { get; set; }
        public Favourite Favourite { get; set; }

        public int ProductId { get; set; }
        public Product Products { get; set; }

    }
}
