namespace Mari.Domain.Common.Entities;

public abstract class EntityBase<TId>
{
    public abstract TId Id { get; init; }

    protected EntityBase(TId id)
    {
        Id = id;
    }
}