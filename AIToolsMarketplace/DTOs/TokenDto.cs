namespace AIToolsMarketplace.DTOs
{
    public class TokenDto
    {
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public string TokenType { get; set; } = "Bearer";
    }
}