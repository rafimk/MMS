using MMS.Shared.Exceptions;

namespace MMS.Modules.Nationalities.Core.Exceptions;

public class InvalidDistrictNameException : MMSException
{
    public string Name { get; }

    public InvalidDistrictNameException(string name) : base($"District name : '{name}' is invalid.")
    {
        Name = name;
    }
}