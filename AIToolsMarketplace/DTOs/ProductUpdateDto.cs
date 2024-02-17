using System.ComponentModel.DataAnnotations;

namespace AIToolsMarketplace.DTOs
{
    //to ProductCreateDto but might include Id and potentially other fields specific to updating
    public class ProductUpdateDto
    {
        [Required]
        public int ProductId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 999999999.99)] // Assuming the maximum price is  999999999.99
        public decimal? Price { get; set; }

        public int? CategoryId { get; set; }
    }
}
