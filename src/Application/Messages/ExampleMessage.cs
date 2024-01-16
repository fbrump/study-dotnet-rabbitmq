namespace Application.Messages;

public record ExampleMessage
{
    public Guid Id { get; init; }

    public string Message { get; init; } = string.Empty;
}