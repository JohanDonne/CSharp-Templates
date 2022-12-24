using Template.Domain.Interfaces;
using Template.Domain2.Entities;

namespace Template.DataAccessLayer2;
public class WeatherForecastService : IWeatherForecastService
{
    // Source: inspired by Microsoft Blazor App Template

    private static readonly string[] _summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public async Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        await Task.Delay(Random.Shared.Next(500, 2000));
        return await Task.FromResult(Enumerable.Range(1, 7).Select(index =>
        {
            int temp = Random.Shared.Next(-20, 50);
            return new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = temp,
                Summary = _summaries[(temp + 20) * (_summaries.Length - 1) / 70]
            };
        }).ToArray());
    }
}
