using Mari.Domain.Common.Entities;
using Mari.Domain.ValueObjects;

namespace Mari.Domain.Entities;

public class Issue : EntityBase<string>
{
    public Issue(string id) : base(id)
    {
    }

    public override string Id { get; init; }
    public string Title { get; init; }
}