using Application.Configurations;
using MassTransit;
using Microsoft.Extensions.Options;

namespace Application.Consumers;

public class CreateUserConsumerDefinition: ConsumerDefinition<CreateUserConsumer>
{
    public CreateUserConsumerDefinition(IOptions<RabbitMqOptions> configureOptions)
    {
        EndpointName = configureOptions.Value.CreateUser?.QueueName ?? "null-queue";
        ConcurrentMessageLimit = configureOptions.Value.CreateUser?.ConcurrentMessageLimit;
    }
}