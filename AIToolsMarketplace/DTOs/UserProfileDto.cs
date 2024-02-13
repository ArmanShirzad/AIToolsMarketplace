namespace AIToolsMarketplace.DTOs
{
    public class UserProfileDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        // Include additional profile information as needed
        // For example, if users have bios or profile images
        public string Bio { get; set; }
        public string ProfileImageUrl { get; set; }

        // Consider including fields for user preferences or settings if applicable
    }
}