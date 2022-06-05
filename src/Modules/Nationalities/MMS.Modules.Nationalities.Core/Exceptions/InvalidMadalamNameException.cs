using MMS.Shared.Exceptions;

namespace MMS.Modules.Nationalities.Core.Exceptions;

public class InvalidMadalamNameException : MMSException
{
    public string Name { get; }

    public InvalidMadalamNameException(string name) : base($"Madalam name : '{name}' is invalid.")
    {
        Name = name;
    }
}