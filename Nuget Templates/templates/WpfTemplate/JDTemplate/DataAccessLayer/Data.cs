using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Interfaces;

namespace JDTemplate.DataAccessLayer;

public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "3 - Layer App (Class Libraries)", Author = "SolutionAuthor" };
}
