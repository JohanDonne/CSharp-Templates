using Templates.LogicLayer;
using Templates.DataAccessLayer;
using Templates.Domain.Interfaces;
using Templates.PresentationLayer;

namespace Templates.AppRoot;

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
