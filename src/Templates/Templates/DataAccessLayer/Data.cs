using Templates.Domain.Entities;
using Templates.Domain.Interfaces;

namespace Templates.DataAccessLayer;
public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "3 - Layer App(Class Libraries)", Author = "SolutionAuthor" };
}
