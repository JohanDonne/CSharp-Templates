using JDTemplate.Core;
using JDTemplate.Infrastructure;
using JDTemplate.Presentation;
using Microsoft.Extensions.DependencyInjection;

namespace JDTemplate.AppRoot;
internal class Program
{
    // Composition root for App

    private static IServiceProvider? _serviceProvider;

    public static async Task Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        _serviceProvider = serviceCollection.BuildServiceProvider();
        await Startup();
    }

    private static async Task Startup()
    {
        var UI = _serviceProvider!.GetService<ConsoleUi>();
        if (UI != null) await UI.Run();
    }

    private static void ConfigureServices(ServiceCollection serviceCollection)
    {
        serviceCollection.AddCoreServices();
        serviceCollection.AddInfrastructureServices();
        serviceCollection.AddPresentationServices();
    }
}
