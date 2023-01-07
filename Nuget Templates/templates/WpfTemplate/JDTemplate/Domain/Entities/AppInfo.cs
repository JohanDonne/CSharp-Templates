namespace JDTemplate.Domain.Entities;

public readonly record struct AppInfo
{
    public string Name { get; init; }
    public string CreationDate { get; init; }
}
