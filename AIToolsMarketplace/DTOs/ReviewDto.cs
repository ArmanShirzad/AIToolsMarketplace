namespace AIToolsMarketplace.DTOs
{
    public class ReviewDto
    {
        public int ReviewId { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}
