using MMS.Shared.Exceptions;

namespace MMS.Modules.Users.Core.Exceptions;

internal sealed class InvalidFullNameException : MMSException
{
    public string FullName { get; }

    public InvalidFullNameException(string fullName) : base($"Full name: '{fullName}' is invalid.")
    {
        FullName = fullName;
    }
}