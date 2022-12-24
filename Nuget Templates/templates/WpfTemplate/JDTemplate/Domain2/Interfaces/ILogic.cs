using JDTemplate.Domain.Entities;
using JDTemplate.Domain2.Entities;

namespace JDTemplate.Domain.Interfaces;

public interface ILogic
{
    AppInfo Info { get; }

    Task<WeatherForecast[]> GetForecastAsync();
}
