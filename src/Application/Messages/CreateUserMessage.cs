namespace Application.Messages;

public record CreateUserMessage
{
    public Guid Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public string LastName { get; init; } = string.Empty;

    public DateTime Birthday { get; init; }
}