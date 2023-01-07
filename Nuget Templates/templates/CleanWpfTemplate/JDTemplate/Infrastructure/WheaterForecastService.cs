using JDTemplate.Core.Exceptions;
using JDTemplate.Core.Interfaces;
using JDTemplate.Core.Models;
using JDTemplate.Domain.Enums;

namespace JDTemplate.Infrastructure;
public class WeatherForecastService : IWeatherForecastService
{
    // Source: inspired by Microsoft Blazor App Template

    public async Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate, TimePeriod period)
    {
        await Task.Delay(Random.Shared.Next(500, 2000));
        // simulate possible error in retrieving forecast
        if (Random.Shared.Next(10) == 0) throw new ForecastNotAvailableException();

        int limit = period switch
        {
            TimePeriod.Week => 7,
            TimePeriod.Fortnight => 14,
            _ => 1,
        };
        return await Task.FromResult(Enumerable.Range(1, limit)
                         .Select(index => new WeatherForecast
                         {
                             Date = startDate.AddDays(index),
                             Temperature = new(Random.Shared.Next(-20, 50))
                         })
                         .ToArray());
    }
}
