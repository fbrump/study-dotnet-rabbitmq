using Presentation.WebApi.Workers;

namespace Presentation.WebApi.Configurations;

internal static class WorkersConfigurations
{
    public static IServiceCollection ConfigureWorkers(this IServiceCollection services)
    {
        services.AddHostedService<ExampleWorker>();

        return services;
    }
}