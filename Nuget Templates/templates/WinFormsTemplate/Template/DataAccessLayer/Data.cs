using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.DataAccessLayer;

public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "3 - Layer App (Class Libraries)", Author = "SolutionAuthor" };
}
