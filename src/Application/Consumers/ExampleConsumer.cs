using Application.Messages;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace Application.Consumers;

public sealed class ExampleConsumer : IConsumer<ExampleMessage>
{
    private readonly ILogger<ExampleConsumer> _logger;

    public ExampleConsumer(ILogger<ExampleConsumer> logger)
    {
        this._logger = logger;    
    }

    public async Task Consume(ConsumeContext<ExampleMessage> context)
    {
        this._logger.LogInformation("[ {consumer} ] The message ({messageId}) was processed at {datetime} with the content {message}.",
            nameof(ExampleConsumer), context.MessageId, DateTime.UtcNow, context.Message);

        await Task.CompletedTask;
    }
}
