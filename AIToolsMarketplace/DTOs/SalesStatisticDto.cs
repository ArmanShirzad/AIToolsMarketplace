namespace AIToolsMarketplace.DTOs
{
    // developer service
    public class SalesStatisticDto
    {
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public int TotalSales { get; set; }
        public decimal TotalRevenue { get; set; }
        // Consider including additional metrics as needed, like views or ratings
    }
}
