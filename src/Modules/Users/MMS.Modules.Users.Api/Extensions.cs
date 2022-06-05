using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MMS.Modules.Users.Core;

namespace MMS.Modules.Users.Api;


public static class Extensions
{
    public static IServiceCollection AddUsersModule(this IServiceCollection services)
    {
        services.AddCoreLayer();
        
        return services;
    }
    
    public static IApplicationBuilder UseUsersModule(this IApplicationBuilder app)
    {
        return app;
    }
}
