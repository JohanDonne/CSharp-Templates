using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDTemplate.Domain.Exceptions;
public  class InvalidTemperatureException: Exception
{
    public InvalidTemperatureException() : base() { }   
    public InvalidTemperatureException(string message) : base(message) { }

    public InvalidTemperatureException(int value) : base($"Invalid temperature value: {value}°C") { }
}
