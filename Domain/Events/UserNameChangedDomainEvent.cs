using Domain.Core.Events;
using Domain.Entities;

namespace Domain.Events;

public class UserNameChangedDomainEvent : IDomainEvent
{
    public UserNameChangedDomainEvent(User user) => User = user;
    
    public User User { get; } 
}

