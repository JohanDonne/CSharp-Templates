using Template.LogicLayer;
using Template.PresentationLayer;
using System.Windows;
using Template.DataLayer;
using Template.Domain.Interfaces;

namespace Template.AppRoot;
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
