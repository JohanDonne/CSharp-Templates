using Template.Domain2.Entities;

namespace Template.Domain.Interfaces;
public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate);
}