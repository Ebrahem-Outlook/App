using Domain.Core.Events;
using Domain.Entities;

namespace Domain.Events;

public sealed class UserCreateDomainEvent : IDomainEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCreateDomainEvent"/> class.
    /// </summary>
    /// <param name="user"></param>
    internal UserCreateDomainEvent(User user) => User = user;

    /// <summary>
    /// Get user 
    /// </summary>
    public User User { get; }
}
