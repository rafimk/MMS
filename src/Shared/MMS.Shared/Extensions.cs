using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MMS.Shared.Commands;
using MMS.Shared.Database;
using MMS.Shared.Dispatchers;
using MMS.Shared.Events;
using MMS.Shared.Exceptions;
using MMS.Shared.Messaging;
using MMS.Shared.Queries;
using MMS.Shared.Time;

namespace MMS.Shared;

public static class Extensions
{
    private const string ApiTitle = "MMS API";
    private const string ApiVersion = "v1";
        
    public static IServiceCollection AddSharedFramework(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddErrorHandling();
        services.AddCommands();
        services.AddEvents();
        services.AddQueries();
        services.AddMessaging();
        services.AddPostgres(configuration);
        services.AddControllers();
        services.AddSingleton<IClock, UtcClock>();
        services.AddSingleton<IDispatcher, InMemoryDispatcher>();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddSwaggerGen(swagger =>
        {
            swagger.EnableAnnotations();
            swagger.CustomSchemaIds(x => x.FullName);
            swagger.SwaggerDoc(ApiVersion, new OpenApiInfo
            {
                Title = ApiTitle,
                Version = ApiVersion
            });
        });
            
        return services;
    }
        
    public static IApplicationBuilder UseSharedFramework(this IApplicationBuilder app)
    {
        app.UseErrorHandling();
        app.UseSwagger();
        app.UseReDoc(reDoc =>
        {
            reDoc.RoutePrefix = "docs";
            reDoc.SpecUrl($"/swagger/{ApiVersion}/swagger.json");
            reDoc.DocumentTitle = ApiTitle;
        });
        app.UseRouting();
            
        return app;
    }
}