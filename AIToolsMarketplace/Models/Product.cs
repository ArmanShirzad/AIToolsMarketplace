using System.ComponentModel.DataAnnotations;

namespace AIToolsMarketplace.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; } // Foreign key
        public Category Category { get; set; } // Navigation property

        public ICollection<Reviews> Reviews { get; set; }

        public Product()
        {
            Reviews = new HashSet<Reviews>();
        }
    }
}