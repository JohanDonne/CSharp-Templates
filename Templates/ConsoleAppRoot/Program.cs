using DataAccessLayer;
using Domain.Interfaces;
using LogicLayer;
using PresentationLayer;

namespace AppRoot;

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
