namespace AIToolsMarketplace.DTOs
{
    // admin service
    public class UserManagementDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; } // Assuming users can have multiple roles
        public bool IsActive { get; set; }
        // Potentially include properties for enabling/disabling accounts, etc.
    }
}
