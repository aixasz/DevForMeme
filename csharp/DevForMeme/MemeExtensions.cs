using Microsoft.Extensions.DependencyInjection;

namespace DevForMeme;

/// <summary>
/// Meme driven development.
/// </summary>
public static class MemeExtensions
{
    /// <summary>
    /// YOLO : Your object life once.
    /// </summary>
    public static IServiceCollection Yolo<TService, TImplementation>(this IServiceCollection services)
        where TService : class
        where TImplementation : class, TService
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        return services.AddSingleton(typeof(TService), typeof(TImplementation));
    }
}
