
using Application.Services.Identity;
using Infrastructure.Context;
using Infrastructure.Services.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")))
                .AddTransient<ApplicationDBSeeder>();
            return services;
        }

        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services
                .AddTransient<ITokenService, TokenService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IRoleService, RoleService>()
                //.AddHttpContextAccessor()
                .AddScoped<ICurrentUserService, CurrentUserService>();

            return services;
        }

        public static void AddInfrastructureDependencies(this IServiceCollection services)
        {
          services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

    }
}
