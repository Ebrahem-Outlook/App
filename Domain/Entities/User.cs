using Domain.Core.Base;
using Domain.Core.Events;
using Domain.Events;

namespace Domain.Entities;

/// <summary>
/// Represint the user class.
/// </summary>
public class User : AggregateRoot
{
    /// <summary>
    /// Create instance frome user class.
    /// </summary>
    /// <param name="firstName">user first name.</param>
    /// <param name="lastName">user last name.</param>
    /// <param name="email">user email.</param>
    /// <param name="password">user password.</param>
    public User(string firstName, string lastName, string email, string password) : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }


    /// <summary>
    /// Get the user first name.
    /// </summary>
    public string FirstName { get; private set; } = string.Empty;

    /// <summary>
    /// Get the user last name.
    /// </summary>
    public string LastName { get; private set; } = string.Empty;

    /// <summary>
    /// Get the user email.
    /// </summary>
    public string Email { get; private set; } = string.Empty;

    /// <summary>
    /// Get the user password.
    /// </summary>
    public string Password { get; private set; } = string.Empty;

    /// <summary>
    /// Factory Methoed for create instance for user class.
    /// </summary>
    /// <param name="firstName">user first name.</param>
    /// <param name="lastName">user last name.</param>
    /// <param name="email">user email.</param>
    /// <param name="password">user password hash.</param>
    /// <returns></returns>
    public static User Create(string firstName, string lastName, string email, string password)
    {
        var user = new User(firstName, lastName, email, password);

        user.AddDomainEvent(new UserCreateDomainEvent(user)); ;

        return user;
    }

    public void ChangePassword(string passwordHash)
    {
        if(passwordHash is null)
        {
            throw new ArgumentNullException();
        }

        Password = passwordHash;

        AddDomainEvent(new UserPasswordChangedDomainEvent(this));
    }

    public void ChangeName(string firstName, string lastName)
    {
        if (firstName == null || lastName == null)
        {
            throw new ArgumentNullException();
        }

        FirstName = firstName;

        LastName = lastName;

        AddDomainEvent(new UserNameChangedDomainEvent(this));
    }

    public void ChangeEmail(string email)
    {
        if (email is null)
        {
            throw new ArgumentNullException();
        }
;
        FirstName = email;

        AddDomainEvent(new UserEmailChangedDomainEvent(this));
    }
}



