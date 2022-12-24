using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Interfaces;

namespace JDTemplate.LogicLayer;

public class Logic : ILogic
{
    private readonly IData _data;

    public AppInfo Info => _data.Info;

    public Logic(IData data)
    {
        _data = data;
    }
}
