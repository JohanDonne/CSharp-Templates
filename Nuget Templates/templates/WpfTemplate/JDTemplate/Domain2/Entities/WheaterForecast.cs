namespace JDTemplate.Domain.Entities;

public class WeatherForecast
{
    // Source: inspired by Microsoft Blazor App Template

    private static readonly string[] _summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public DateOnly Date { get; set; }

    public int TemperatureCelsius { get; set; }

    public string Summary => TemperatureCelsius switch
    {
        <= -20  => _summaries[0],
        >= 50   => _summaries[^1],
        _       => _summaries[(TemperatureCelsius + 20) * (_summaries.Length - 1) / 70]
    };
}
