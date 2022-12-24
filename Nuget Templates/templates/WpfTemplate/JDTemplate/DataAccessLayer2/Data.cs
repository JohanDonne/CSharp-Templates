using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Interfaces;

namespace JDTemplate.DataAccessLayer;

public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "MVVM 3-Layer App (Class Libraries, DI)", Author = "SolutionAuthor" };
}
