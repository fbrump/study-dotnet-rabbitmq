using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Queries;

public sealed class ExampleQueryHandler : IRequestHandler<ExampleQuery, IEnumerable<string>>
{
    private readonly ILogger<ExampleQueryHandler> _logger;

    public ExampleQueryHandler(ILogger<ExampleQueryHandler> logger)
    {
        this._logger = logger;
    }

    public async Task<IEnumerable<string>> Handle(ExampleQuery request, CancellationToken cancellationToken)
    {
        this._logger.LogInformation("[ {commandHandler} - {command} ]  The command ({messageId}) was executed at {datetime}.",
            nameof(ExampleQueryHandler), nameof(ExampleQuery), request, DateTime.UtcNow);

        await Task.CompletedTask;

        var programLanguageExamples = new string[] { "c#", "python", "javascript", };

        this._logger.LogInformation("[ {commandHandler} - {command} ]  There are {countProgramLanguages} at {datetime}.",
            nameof(ExampleQueryHandler), nameof(ExampleQuery), programLanguageExamples.Length, DateTime.UtcNow);

        return programLanguageExamples;
    }
}