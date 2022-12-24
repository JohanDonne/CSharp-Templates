using JDTemplate.Domain2.Entities;

namespace JDTemplate.Domain.Interfaces;
public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate);
}