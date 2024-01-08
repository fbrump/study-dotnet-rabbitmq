using MediatR;

namespace Application.Commands;

public sealed class ExampleCommandHandler : IRequestHandler<ExampleCommand>
{
    public async Task Handle(ExampleCommand request, CancellationToken cancellationToken)
    {
        // TODO: Implement the logic here.
        await Task.CompletedTask;
    }
}