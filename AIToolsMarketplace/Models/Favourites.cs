using System.ComponentModel.DataAnnotations;

namespace AIToolsMarketplace.Models
{
    public class Favourite
    {
        [Key]
        public int FavoriteId { get; set; }

        [Required]
        public string UserId { get; set; } // foreign key
        public ApplicationUser User { get; set; } // navigation property

        public ICollection<Product> Products { get; set; }


    }
}
