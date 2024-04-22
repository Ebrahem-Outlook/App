using Domain.Core.Events;
using Domain.Entities;

namespace Domain.Events;

internal class UserPasswordChangedDomainEvent : IDomainEvent
{
    public UserPasswordChangedDomainEvent(User user) => User = user;
    

    public User User { get; }
}
