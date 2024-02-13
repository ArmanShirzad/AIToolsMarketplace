using AIToolsMarketplace.Services.Token;
using AIToolsMarketplace.Services.User;

using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

using System.Text;

namespace AIToolsMarketplace.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayerServices(this IServiceCollection services,  IConfiguration configuration) 
        {
            // Register your services here
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>(); // Assuming TokenService is your JWT token generator

            // AutoMapper configuration
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Add other service registrations as needed

            // If using JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidIssuer = configuration["Jwt:Issuer"],
                        ValidAudience = configuration["Jwt:Audience"]
                    };
                });

            return services;

        }
    }
}
