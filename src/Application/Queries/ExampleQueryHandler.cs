using MediatR;

namespace Application.Queries;

public sealed class ExampleQueryHandler : IRequestHandler<ExampleQuery, IEnumerable<string>>
{
    public async Task<IEnumerable<string>> Handle(ExampleQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return new string[] { "c#", "python", "javascript", };
    }
}