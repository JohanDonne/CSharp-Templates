using Template.LogicLayer;
using Template.PresentationLayer;
using Template.DataAccessLayer;
using Template.Domain.Interfaces;

namespace Template.AppRoot;

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