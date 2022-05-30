using MMS.Shared.Exceptions;

namespace MMS.Modules.Users.Core.Exceptions;

internal sealed class UserAlreadyVerifiedException : MMSException
{
    public Guid UserId { get; }

    public UserAlreadyVerifiedException(Guid userId) : base($"User with ID: '{userId}' is already verified.")
    {
        UserId = userId;
    }
}