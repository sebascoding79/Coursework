namespace Coursework.API.Extensions;

// Static classes have only static methods

public static class HostEnvironmentExtensions
{
    public static bool IsLocal(this IHostEnvironment hostEnvironment) =>
        hostEnvironment.IsEnvironment("Local");
}