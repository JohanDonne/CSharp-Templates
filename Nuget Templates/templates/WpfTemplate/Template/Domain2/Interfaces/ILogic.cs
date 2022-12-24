using Template.Domain.Entities;
using Template.Domain2.Entities;

namespace Template.Domain.Interfaces;

public interface ILogic
{
    AppInfo Info { get; }

    Task<WeatherForecast[]> GetForecastAsync();
}
