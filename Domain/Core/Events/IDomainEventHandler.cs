using MediatR;

namespace Domain.Core.Events;

/// <summary>
/// Represents a domain event handler interface 
/// </summary>
/// <typeparam name="TDomainEvent"></typeparam>
public interface IDomainEventHandler<in TDomainEvent> : INotificationHandler<TDomainEvent> 
    where TDomainEvent : IDomainEvent
{

}
