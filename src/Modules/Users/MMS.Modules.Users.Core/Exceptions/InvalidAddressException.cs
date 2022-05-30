using MMS.Shared.Exceptions;

namespace MMS.Modules.Users.Core.Exceptions;

internal sealed class InvalidAddressException : MMSException
{
    public string Address { get; }

    public InvalidAddressException(string address) : base($"Address: '{address}' is invalid.")
    {
        Address = address;
    }
}