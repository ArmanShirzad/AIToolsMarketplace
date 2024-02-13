using AIToolsMarketplace.DTOs;

namespace AIToolsMarketplace.Services.User
{
    public interface IUserService
    {
        Task<UserDto> RegisterUserAsync(UserRegistrationDto userRegistration);
        Task<TokenDto> AuthenticateUserAsync(UserLoginDto userLogin);
        Task AssignRoleAsync(string userId, string role);
        Task<UserProfileDto> GetUserProfileAsync(string userId);
    }
}
