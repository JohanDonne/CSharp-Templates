using JDTemplate.Domain.Entities;

namespace JDTemplate.Domain.Interfaces;
public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate);
}