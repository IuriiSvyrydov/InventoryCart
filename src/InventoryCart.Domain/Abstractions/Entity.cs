namespace InventoryCart.Domain.Abstractions;

public abstract class Entity
{
    public Guid Id { get;private set; }
    public Guid CreatedBy { get; private set; }
    public Guid ModifyBy { get; private set; }
    public DateTimeOffset CreatedOn { get; private set; }
    public DateTimeOffset ModifyOn { get; private set; }






     private readonly List<IDomainEvent>_domainEvents = new ();
    protected Entity()
    {
        
    }

    public Entity(Guid id)
    {
        Id = id;
    }

    public IReadOnlyCollection<IDomainEvent> GetEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearEvent()
    {
        _domainEvents.Clear();

    }

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}