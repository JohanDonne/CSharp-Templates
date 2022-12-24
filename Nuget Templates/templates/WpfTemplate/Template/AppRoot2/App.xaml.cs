﻿using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Template.DataAccessLayer;
using Template.Domain;
using Template.Domain.Interfaces;
using Template.LogicLayer;
using Template.PresentationLayer;
using Template.PresentationLayer.Views;

namespace Template.AppRoot;
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
        serviceCollection.AddDomainServices();
        serviceCollection.AddDataAccessServices();
        serviceCollection.AddLogicServices();
        serviceCollection.AddPresentationServices();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var mainWindow = _serviceProvider.GetService<MainWindow>();
        mainWindow?.Show();
    }
}