using Templates.Domain.Entities;
using Templates.Domain.Interfaces;

namespace Templates.LogicLayer;
public class Logic : ILogic
{
    private readonly IData _data;

    public AppInfo Info => _data.Info;

    public Logic(IData data)
    {
        _data = data;
    }
}

