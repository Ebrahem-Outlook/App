using MediatR;

namespace Domain.Core.Events;

/// <summary>
/// Represents IDomainEvent interface
/// </summary>
public interface IDomainEvent : INotification
{
}
