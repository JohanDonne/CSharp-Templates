using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Interfaces;

namespace JDTemplate.DataLayer;

public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "3 - Layer App (Project Folders)", Author = "SolutionAuthor" };
}
