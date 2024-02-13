namespace AIToolsMarketplace.DTOs
{
    // developer service

    public class ToolListingDto
    {
        public int ToolId { get; set; } // For updates. Could be 0 for new listings.
        public string DeveloperId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } // Assuming a simple category representation. Use CategoryId for more complex scenarios.
        public bool IsActive { get; set; }

        // Add fields for images, technical requirements, etc., as necessary.
    }
}
