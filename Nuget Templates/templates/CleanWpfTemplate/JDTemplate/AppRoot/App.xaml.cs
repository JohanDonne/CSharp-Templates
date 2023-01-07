using JDTemplate.Core;
using JDTemplate.Infrastructure;
using JDTemplate.Presentation;
using JDTemplate.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Windows;
using System.Windows.Markup;

namespace JDTemplate.AppRoot;
/// <summary>
/// Composition root for App
/// </summary>
public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    public App()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        _serviceProvider = serviceCollection.BuildServiceProvider();
    }

    private static void ConfigureServices(ServiceCollection serviceCollection)
    {
        serviceCollection.AddCoreServices();
        serviceCollection.AddInfrastructureServices();
        serviceCollection.AddPresentationServices();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        // Change Language & culture for WPF FrameworkEelements form en-US to the local Windows Settings.
        FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
           new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
        base.OnStartup(e);

        var mainWindow = _serviceProvider.GetService<MainWindow>();
        mainWindow?.Show();
    }
}
