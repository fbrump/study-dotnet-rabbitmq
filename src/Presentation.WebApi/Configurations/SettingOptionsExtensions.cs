using Application.Configurations;

namespace Presentation.WebApi.Configurations;

internal static class SettingOptionsExtensions
{
    public static IServiceCollection ConfigureSettingOptions(this IServiceCollection services, IConfiguration configuration)
    {
        var serviceDependencySection = configuration.GetSection(ServiceDependencyOptions.AppsettingSectionName);
        
        services.Configure<ServiceDependencyOptions>(serviceDependencySection);
        
        services.Configure<RabbitMqOptions>(
            serviceDependencySection.GetSection(RabbitMqOptions.AppsettingSectionName));

        return services;
    }

}
