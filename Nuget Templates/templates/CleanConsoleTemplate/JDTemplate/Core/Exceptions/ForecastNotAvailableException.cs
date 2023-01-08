using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDTemplate.Core.Exceptions;
public  class ForecastNotAvailableException: Exception
{
    public ForecastNotAvailableException() : base() { }   
    public ForecastNotAvailableException(string message) : base(message) { }
}
