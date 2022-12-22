using Template.LogicLayer;
using Template.DataAccessLayer;
using Template.Domain.Interfaces;
using Template.PresentationLayer;

namespace Template.AppRoot;

internal class Program
{
    // Composition root for App

    private static void Main(string[] args)
    {
        IData data = new Data();
        ILogic logic = new Logic(data);
        new ConsoleUi(logic).Run();
    }
}
