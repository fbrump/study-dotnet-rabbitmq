namespace Application.Configurations;

public class RabbitMqOptions
{
    public static string AppsettingSectionName { get; set; } = "RabbitMQ";

    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string VirtualHost { get; set; } = string.Empty;
    public string HostName { get; set; } = string.Empty;

    public CreateUserOptions CreateUser { get; set; } = new();
}