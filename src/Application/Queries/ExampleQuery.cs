using MediatR;

namespace Application.Queries;

public sealed record ExampleQuery(Guid Id) : IRequest<IEnumerable<string>>;
