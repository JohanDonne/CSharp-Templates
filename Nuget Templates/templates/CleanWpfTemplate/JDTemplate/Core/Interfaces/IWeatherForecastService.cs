using JDTemplate.Core.Models;
using JDTemplate.Domain.Enums;

namespace JDTemplate.Core.Interfaces;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate, TimePeriod period);
}