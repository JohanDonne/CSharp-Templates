using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.LogicLayer;

public class Logic : ILogic
{
    private readonly IData _data;

    public AppInfo Info => _data.Info;

    public Logic(IData data)
    {
        _data = data;
    }
}