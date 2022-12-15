using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templates.Domain.Entities;
public readonly record struct AppInfo
{
    public string Name { get; init; }
    public string Author { get; init; }
}
