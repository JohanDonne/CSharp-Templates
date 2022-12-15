using Templates.LogicLayer;
using Templates.PresentationLayer;
using System.Windows;
using Templates.DataAccessLayer;
using Templates.Domain.Interfaces;

namespace Templates.AppRoot;
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
