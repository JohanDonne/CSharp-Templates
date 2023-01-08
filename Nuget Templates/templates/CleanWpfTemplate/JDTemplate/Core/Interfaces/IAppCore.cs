using JDTemplate.Core.Models;
using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDTemplate.Core.Interfaces;
public interface IAppCore
{

    public AppInfo Info { get; }

    public Task<WeatherForecast[]> GetForecastAsync(TimePeriod period);
}
