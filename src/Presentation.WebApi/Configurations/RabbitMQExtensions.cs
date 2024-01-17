using Application.Configurations;
using Application.Consumers;
using Application.Messages;
using MassTransit;

namespace Presentation.WebApi.Configurations;

internal static class RabbitMQExtensions
{
    internal static IServiceCollection ConfigureRabbitMq(this IServiceCollection services, IConfiguration configuration)
    {
        var rabbitMQConfigurations = configuration
            .GetSection(ServiceDependencyOptions.AppsettingSectionName)
            .GetSection(RabbitMqOptions.AppsettingSectionName)
            .Get<RabbitMqOptions>() ?? new();

        services.AddMassTransit(x =>
            {
                x.AddConsumer<ExampleConsumer>();
                x.AddConsumer<CreateUserConsumer, CreateUserConsumerDefinition>();

                x.UsingRabbitMq((context,cfg) =>
                {
                    cfg.Host(rabbitMQConfigurations.HostName, rabbitMQConfigurations.VirtualHost, h => {
                        h.Username(rabbitMQConfigurations.UserName);
                        h.Password(rabbitMQConfigurations.Password);
                    });

                    cfg.ConfigureEndpoints(context);
                });
            });

        return services;
    }
}