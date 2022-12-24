namespace JDTemplate.Domain2.Entities;
public class WeatherForecast
{
    // Source: Microsoft Blazor App Template

    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
