using JDTemplate.Core.Interfaces;
using JDTemplate.Domain.Entities;

namespace JDTemplate.Infrastructure;

public class AppInfoService : IAppInfoService
{
    public AppInfo Info { get; } = new AppInfo { Name = "WPF MVVM App (Clean Architecture, DI)", CreationDate = "01/01/1901" };
}
