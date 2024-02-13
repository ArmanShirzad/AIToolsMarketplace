namespace AIToolsMarketplace.DTOs
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public IEnumerable<OrderItemDto> Items { get; set; }
    }
}
