using Domain.Interfaces;

namespace LogicLayer;
public class Logic : ILogic
{
    private readonly IData _data;

    public string AppName => _data.AppName;

    public Logic(IData data)
    {
        _data = data;
    }
}