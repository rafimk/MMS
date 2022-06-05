using MMS.Shared.Exceptions;

namespace MMS.Modules.Nationalities.Core.Exceptions;

public class InvalidStateNameException : MMSException
{
    public string Name { get; }

    public InvalidStateNameException(string name) : base($"State name : '{name}' is invalid.")
    {
        Name = name;
    }
}