using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.DataAccessLayer;

public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "MVVM 3-Layer App (Class Libraries, DI)", Author = "SolutionAuthor" };
}
