using AIToolsMarketplace.DTOs;
using AIToolsMarketplace.Models;
using AIToolsMarketplace.Services.Token;

using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AIToolsMarketplace.Services.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenservice;

        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IMapper mapper, ITokenService tokenservice)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _tokenservice = tokenservice;
        }

        public async Task AssignRoleAsync(string userId, string role)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new ApplicationException("User not found.");
            }
            var result = await _userManager.AddToRoleAsync(user, role);
            if (!result.Succeeded)
            {
                throw new ApplicationException($"Failed to assign role {role} to user.");
            }
        }

        public async Task<TokenDto> AuthenticateUserAsync(UserLoginDto userLogin)
        {
            var user = await _userManager.FindByNameAsync(userLogin.UserName);
            if (user == null)
            {
                throw new ApplicationException("User not found.");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, userLogin.Password, false);
            if (!result.Succeeded)
            {
                throw new ApplicationException("Invalid login attempt.");
            }

            var token = await _tokenservice.GenerateToken(user);
            return new TokenDto { Token = token };
        }

        public async Task<UserProfileDto> GetUserProfileAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new ApplicationException("user not found");
            }
            return _mapper.Map<UserProfileDto>(user);

        }

        public async Task<UserDto> RegisterUserAsync(UserRegistrationDto userRegistration)
        {
            var user = _mapper.Map<ApplicationUser>(userRegistration);
            var result = await _userManager.CreateAsync(user, userRegistration.Password);
            if (!result.Succeeded)
            {
                throw new ApplicationException("User registration failed.");
            }
            // Optionally assign a default role or additional steps
            return _mapper.Map<UserDto>(user);      
        }

    }
}
