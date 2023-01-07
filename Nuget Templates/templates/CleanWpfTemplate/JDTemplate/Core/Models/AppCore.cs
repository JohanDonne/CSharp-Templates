using JDTemplate.Core.Interfaces;
using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Enums;

namespace JDTemplate.Core.Models;
public class AppCore : IAppCore
{
    private readonly IAppInfoService _data;
    private readonly IWeatherForecastService _weather;

    public AppInfo Info => _data.Info;

    public AppCore(IAppInfoService data, IWeatherForecastService weather)
    {
        _data = data;
        _weather = weather;
    }

    public async Task<WeatherForecast[]> GetForecastAsync(TimePeriod period)
    {   
        return await _weather.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now), period);
    }
}
