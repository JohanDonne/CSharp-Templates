using Microsoft.Extensions.DependencyInjection;
using Template.PresentationLayer.ViewModels;
using Template.PresentationLayer.Views;

namespace Template.PresentationLayer;
public static class ServiceExtensions
{

    public static void AddPresentationServices(this ServiceCollection services)
    {
        // Register the classes that need to be injected as singleton or transient (or scoped).

        services.AddSingleton<MainWindow>();
        services.AddTransient<MainViewModel>();
    }
}