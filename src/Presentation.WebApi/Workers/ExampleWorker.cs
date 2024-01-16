using Application.Messages;
using MassTransit;

namespace Presentation.WebApi.Workers;

public sealed class ExampleWorker: BackgroundService
{
    private readonly IBus _bus;
    private readonly ILogger<ExampleWorker> _logger;

    public ExampleWorker(IBus bus, ILogger<ExampleWorker> logger)
    {
        _bus = bus;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            this._logger.LogInformation("[ {worker} ] The worker has strated at {datetime}.",
                nameof(ExampleWorker), DateTime.UtcNow);

            var message = new ExampleMessage { Id = Guid.NewGuid(), Message = $"The time is {DateTime.UtcNow}" };

            await _bus.Publish(message, stoppingToken);

            this._logger.LogInformation("[ {worker} ] The worker has produced a message ({messageId}) at {datetime}.",
                nameof(ExampleWorker), message.Id, DateTime.UtcNow);

            this._logger.LogInformation("[ {worker} ] The worker has completed at {datetime}.",
                nameof(ExampleWorker), DateTime.UtcNow);

            await Task.Delay(1000, stoppingToken);
        }
    }
}