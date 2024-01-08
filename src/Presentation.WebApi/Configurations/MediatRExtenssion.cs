using Application;

namespace Presentation.WebApi.Configurations;

internal static class MediatRExtenssion
{
    public static IServiceCollection ConfigureMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(InfoAssembly).Assembly));

        return services;
    }
}
