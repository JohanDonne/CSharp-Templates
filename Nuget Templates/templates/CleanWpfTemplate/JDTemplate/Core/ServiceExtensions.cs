using JDTemplate.Core.Interfaces;
using JDTemplate.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace JDTemplate.Core;
public static class ServiceExtensions
{

    public static void AddCoreServices(this ServiceCollection services)
    {
        // Register the classes that need to be injected as singleton or transient (or scoped).
        services.AddSingleton<IAppCore, AppCore>();
    }
}