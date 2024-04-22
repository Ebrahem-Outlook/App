using Domain.Core.Events;
using Domain.Entities;

namespace Domain.Events;

internal class UserEmailChangedDomainEvent : IDomainEvent
{
    public UserEmailChangedDomainEvent(User user) => User = user;

    public User User { get; }
}
