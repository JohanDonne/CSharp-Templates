using Microsoft.Extensions.DependencyInjection;
using Template.DataAccessLayer2;
using Template.Domain.Interfaces;

namespace Template.DataAccessLayer;
public static class ServiceExtensions
{

    public static void AddDataAccessServices(this ServiceCollection services)
    {
        // Register the classes that need to be injected as singleton or transient (or scoped).

        services.AddSingleton<IData, Data>();
        services.AddTransient<IWeatherForecastService, WeatherForecastService>();
    }
}