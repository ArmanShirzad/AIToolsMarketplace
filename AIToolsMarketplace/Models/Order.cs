namespace AIToolsMarketplace.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; } // Assuming you're using ASP.NET Core Identity
        public ApplicationUser User { get; set; }
        public DateTime OrderDate { get; set; }
    }
}