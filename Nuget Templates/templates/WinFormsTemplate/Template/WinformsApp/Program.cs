using Template.DataLayer;
using Template.Domain.Interfaces;
using Template.LogicLayer;
using Template.PresentationLayer;

namespace Template;
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        IData data = new Data();
        ILogic logic = new Logic(data);
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm(logic));
    }
}
