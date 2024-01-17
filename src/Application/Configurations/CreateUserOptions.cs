namespace Application.Configurations;

public class CreateUserOptions
{
    public string QueueName { get; set; } = string.Empty;

    public int ConcurrentMessageLimit { get; set; }
}