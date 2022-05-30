using MMS.Shared.Exceptions;

namespace MMS.Modules.Users.Core.Exceptions;

internal sealed class UserAlreadyExistsException : MMSException
{
    public string Email { get; }

    public UserAlreadyExistsException(string email) : base($"User with email: '{email}' already exists.")
    {
        Email = email;
    }
}