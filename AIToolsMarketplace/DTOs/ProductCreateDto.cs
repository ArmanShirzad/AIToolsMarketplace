using System.ComponentModel.DataAnnotations;

namespace AIToolsMarketplace.DTOs
{
    public class ProductCreateDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 999999999.99)] // Assuming the maximum price is  999999999.99
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
