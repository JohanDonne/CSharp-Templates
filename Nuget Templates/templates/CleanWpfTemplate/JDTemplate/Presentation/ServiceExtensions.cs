using JDTemplate.Presentation.ViewModels;
using JDTemplate.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;

namespace JDTemplate.Presentation;
public static class ServiceExtensions
{

    public static void AddPresentationServices(this ServiceCollection services)
    {
        // Register the classes that need to be injected as singleton or transient (or scoped).

        services.AddSingleton<MainWindow>();
        services.AddTransient<MainViewModel>();
    }
}