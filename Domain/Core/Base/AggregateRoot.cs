using Domain.Core.Events;

namespace Domain.Core.Base;

/// <summary>
/// Represint the aggregateroot class
/// </summary>
public abstract class AggregateRoot : Entity
{
    /// <summary>
    /// Create instance of aggregateroot base class.
    /// </summary>
    /// <param name="id">The identifire for the aggregateroot</param>
    protected AggregateRoot(Guid id) : base(id) { }

    /// <summary>
    /// Create instance of aggregateroot base class.
    /// </summary>
    /// <param name="id"></param>
    protected AggregateRoot() : base()  { }

    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();

    /// <summary>
    /// Gets the domain events. This collection is readonly.
    /// </summary>
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    /// <summary>
    /// Clears all the domain events from the <see cref="AggregateRoot"/>
    /// </summary>
    public void ClearDomainEvents() => _domainEvents.Clear();

    /// <summary>
    /// Adds the specified <see cref="IDomainEvent"/>
    /// </summary>
    /// <param name="event">The domain event</param>
    protected void AddDomainEvent(IDomainEvent @event) => _domainEvents.Add(@event);
}
