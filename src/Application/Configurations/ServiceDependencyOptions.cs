namespace Application.Configurations;

public class ServiceDependencyOptions
{
    public static string AppsettingSectionName { get; set; } = "ServiceDependencies";

    public RabbitMqOptions RabbitMq { get; set; } = new();
}
