using AIToolsMarketplace.Models;

namespace AIToolsMarketplace.Services.Token
{
    public interface ITokenService
    {
        Task<string> GenerateToken(ApplicationUser user);
    }
}
