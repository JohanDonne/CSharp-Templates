using JDTemplate.Domain.Entities;

namespace JDTemplate.Domain.Interfaces;

public interface ILogic
{
    AppInfo Info { get; }

    Task<WeatherForecast[]> GetForecastAsync();
}
