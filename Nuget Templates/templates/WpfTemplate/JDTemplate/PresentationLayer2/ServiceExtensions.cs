using Microsoft.Extensions.DependencyInjection;
using JDTemplate.PresentationLayer.ViewModels;
using JDTemplate.PresentationLayer.Views;

namespace JDTemplate.PresentationLayer;
public static class ServiceExtensions
{

    public static void AddPresentationServices(this ServiceCollection services)
    {
        // Register the classes that need to be injected as singleton or transient (or scoped).

        services.AddSingleton<MainWindow>();
        services.AddTransient<MainViewModel>();
    }
}