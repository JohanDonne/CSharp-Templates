using JDTemplate.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JDTemplate.Infrastructure;
public static class ServiceExtensions
{

    public static void AddInfrastructureServices(this ServiceCollection services)
    {
        // Register the classes that need to be injected as singleton or transient (or scoped).
        services.AddTransient<IAppInfoService,AppInfoService>();
        services.AddTransient<IWeatherForecastService,WeatherForecastService>();
    }
}