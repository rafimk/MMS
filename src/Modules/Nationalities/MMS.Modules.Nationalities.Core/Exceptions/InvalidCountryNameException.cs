using MMS.Shared.Exceptions;

namespace MMS.Modules.Nationalities.Core.Exceptions;

public class InvalidCountryNameException : MMSException
{
    public string Name { get; }
    
    public InvalidCountryNameException(string name) :  base($"Country name : '{name}' is invalid.")
    {
        Name = name;
    }
}