using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MMS.Modules.Notifications.Api.Services;
using MMS.Modules.Notifications.Shared;

namespace MMS.Modules.Notifications.Api;

public static class Extensions
{
    public static IServiceCollection AddNotificationsModule(this IServiceCollection services)
    {
        services.AddTransient<INotificationsModuleApi, NotificationsModuleApi>();
        services.AddSingleton<IEmailSender, EmailSender>();
        services.AddSingleton<IEmailResolver, EmailResolver>();
            
        return services;
    }
        
    public static IApplicationBuilder UseNotificationsModule(this IApplicationBuilder app)
    {
        return app;
    }
}