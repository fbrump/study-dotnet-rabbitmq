using Presentation.WebApi.Workers;

namespace Presentation.WebApi.Configurations;

internal static class WorkersConfigurations
{
    public static IServiceCollection ConfigureWorkers(this IServiceCollection services)
    {
        services.AddHostedService<ExampleWorker>();
        services.AddHostedService<ProduceWorkQueueWorker>();

        return services;
    }
}