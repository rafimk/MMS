using MMS.Shared.Exceptions;

namespace MMS.Modules.Users.Core.Exceptions;

internal sealed class UserNotFoundException : MMSException
{
    public Guid UserId { get; }

    public UserNotFoundException(Guid userId) : base($"User with ID: '{userId}' was not found.")
    {
        UserId = userId;
    }
}