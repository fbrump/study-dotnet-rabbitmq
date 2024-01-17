using Application.Messages;
using Bogus;
using MassTransit;

namespace Presentation.WebApi.Workers;

public sealed class ProduceWorkQueueWorker: BackgroundService
{
    private readonly IPublishEndpoint _bus;
    private readonly ILogger<ProduceWorkQueueWorker> _logger;

    public ProduceWorkQueueWorker(IBus bus, ILogger<ProduceWorkQueueWorker> logger)
    {
        _bus = bus;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            this._logger.LogInformation("[ {worker} ] The worker has strated at {datetime}.",
                nameof(ProduceWorkQueueWorker), DateTime.UtcNow);
            
            var message = new Faker<CreateUserMessage>()
                .RuleFor(m => m.Id, f => f.Random.Guid())
                .RuleFor(m => m.Name, f => f.Name.FirstName())
                .RuleFor(m => m.LastName, f => f.Name.LastName())
                .RuleFor(m => m.Birthday, f => f.Person.DateOfBirth)
                .Generate();

            await _bus.Publish(message, stoppingToken);

            this._logger.LogInformation("[ {worker} ] The worker has produced a message ({messageType} - {messageId}) at {datetime}.",
                nameof(ProduceWorkQueueWorker), nameof(CreateUserMessage), message.Id, DateTime.UtcNow);

            this._logger.LogInformation("[ {worker} ] The worker has completed at {datetime}.",
                nameof(ProduceWorkQueueWorker), DateTime.UtcNow);

            await Task.Delay(1000, stoppingToken);
        }
    }
}