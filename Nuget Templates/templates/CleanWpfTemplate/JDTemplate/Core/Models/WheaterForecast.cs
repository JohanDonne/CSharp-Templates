using JDTemplate.Domain.Entities;

namespace JDTemplate.Core.Models;

public class WeatherForecast
{
    public DateOnly Date { get; init; }
    public Temperature Temperature { get; init; }    
}
