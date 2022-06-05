using Microsoft.Extensions.DependencyInjection;
using MMS.Modules.Users.Core.DAL;
using MMS.Modules.Users.Core.Services;
using MMS.Modules.Users.Shared;
using MMS.Shared.Database;

namespace MMS.Modules.Users.Core;


public static class Extensions
{
    public static IServiceCollection AddCoreLayer(this IServiceCollection services)
    {
        services.AddPostgres<UsersDbContext>();
        services.AddTransient<IUsersService, UsersService>();
        services.AddTransient<IUsersModuleApi, UsersModuleApi>();
        
        return services;
    }
}
