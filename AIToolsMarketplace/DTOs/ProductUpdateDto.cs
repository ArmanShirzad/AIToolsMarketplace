namespace AIToolsMarketplace.DTOs
{
    //to ProductCreateDto but might include Id and potentially other fields specific to updating
    public class ProductUpdateDto
    {
        public int ProductId { get; set; }
        // Consider adding properties relevant to updates that are not in ProductCreateDto
    }
}
