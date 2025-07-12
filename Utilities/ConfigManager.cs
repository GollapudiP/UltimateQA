using Microsoft.Extensions.Configuration;

public static class ConfigManager
{
    public static IConfigurationRoot LoadConfig()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        return builder.Build();
    }
}
