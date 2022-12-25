using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Interfaces;

namespace JDTemplate.DataAccessLayer2;
public class WeatherForecastService : IWeatherForecastService
{
    // Source: inspired by Microsoft Blazor App Template

    public async Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        await Task.Delay(Random.Shared.Next(500, 2000));
        return await Task.FromResult(Enumerable.Range(1, 7)
                         .Select(index => new WeatherForecast
                         {
                             Date = startDate.AddDays(index),
                             TemperatureCelsius = Random.Shared.Next(-20, 50)
                         })
                         .ToArray());
    }
}
