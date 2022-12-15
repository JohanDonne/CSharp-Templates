using Templates.LogicLayer;
using Templates.PresentationLayer;
using Templates.DataAccessLayer;
using Templates.Domain.Interfaces;

namespace AppRoot;

internal static class Program
{
    /// <summary>
    ///  Composition root for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        IData data = new Data();
        ILogic logic = new Logic(data);
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm(logic));
    }
}