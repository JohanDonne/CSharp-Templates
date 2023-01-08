using JDTemplate.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDTemplate.Domain.Entities;
public readonly record struct Temperature
{
    private static readonly string[] _summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public int CelsiusValue { get; }

    public string Summary => CelsiusValue switch
    {
        <= -20 => _summaries[0],
        >= 50 => _summaries[^1],
        _ => _summaries[(CelsiusValue + 20) * (_summaries.Length - 1) / 70]
    };

    public Temperature(int value)
    {
        if ((value < -50) || (value > 80)) throw new InvalidTemperatureException(value);
        CelsiusValue = value;
    }
}
