using Template.Domain.Entities;
using Template.Domain.Interfaces;
using Template.Domain2.Entities;

namespace Template.LogicLayer;
public class Logic : ILogic
{
    private readonly IData _data;
    private readonly IWeatherForecastService _weather;

    public AppInfo Info => _data.Info;

    public Logic(IData data, IWeatherForecastService weather)
    {
        _data = data;
        _weather = weather;
    }

    public async Task<WeatherForecast[]> GetForecastAsync()
    {
        return await _weather.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
    }
}
