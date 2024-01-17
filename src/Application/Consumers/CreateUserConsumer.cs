using Application.Messages;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace Application.Consumers;

public class CreateUserConsumer: IConsumer<CreateUserMessage>
{
    private readonly ILogger<CreateUserConsumer> _logger;

    public CreateUserConsumer(ILogger<CreateUserConsumer> logger)
    {
        this._logger = logger;    
    }

    public async Task Consume(ConsumeContext<CreateUserMessage> context)
    {
        this._logger.LogInformation("[ {consumer} ] The message ({messageId}) was processed at {datetime} with the content {message}.",
            nameof(CreateUserConsumer), context.MessageId, DateTime.UtcNow, context.Message);

        await Task.CompletedTask;
    }
}