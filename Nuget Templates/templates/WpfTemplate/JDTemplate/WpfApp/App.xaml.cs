using JDTemplate.LogicLayer;
using JDTemplate.PresentationLayer;
using System.Windows;
using JDTemplate.DataLayer;
using JDTemplate.Domain.Interfaces;

namespace JDTemplate.AppRoot;
/// <summary>
/// Composition root for App
/// </summary>
public partial class App : Application
{

    protected override void OnStartup(StartupEventArgs e)
    {
        IData data = new Data();
        ILogic logic = new Logic(data);
        new MainWindow(logic).Show();
    }
}
