using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.DataAccessLayer;

public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "3 - Layer App (Class Libraries)", CreationDate = "01/01/1901" };
}
