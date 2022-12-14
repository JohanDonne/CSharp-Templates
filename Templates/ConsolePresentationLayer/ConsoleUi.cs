using Domain.Interfaces;

namespace PresentationLayer;
public class ConsoleUi
{
    private readonly ILogic _logic;

    public ConsoleUi(ILogic logic)
    {
        _logic = logic;
    }

    public void Run()
    {
        Console.WriteLine($"Hello World from {_logic.AppName}");
    }
}
