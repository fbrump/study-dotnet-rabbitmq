using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands;

public sealed class ExampleCommandHandler : IRequestHandler<ExampleCommand>
{
    private readonly ILogger<ExampleCommandHandler> _logger;

    public ExampleCommandHandler(ILogger<ExampleCommandHandler> logger)
    {
        this._logger = logger;
    }
    
    public async Task Handle(ExampleCommand request, CancellationToken cancellationToken)
    {
        this._logger.LogInformation("[ {commandHandler} - {command} ] The command ({messageId}) was executed at {datetime}.",
            nameof(ExampleCommandHandler), nameof(ExampleCommandHandler), request, DateTime.UtcNow);
        
        await Task.CompletedTask;
    }
}