using MMS.Shared.Exceptions;

namespace MMS.Modules.Nationalities.Core.Exceptions;

public class InvalidPanchayathNameException : MMSException
{
    public string Name { get; }

    public InvalidPanchayathNameException(string name) : base($"Panchayath name : '{name}' is invalid.")
    {
        Name = name;
    }
}