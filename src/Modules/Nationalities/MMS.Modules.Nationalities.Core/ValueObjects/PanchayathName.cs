using MMS.Modules.Nationalities.Core.Exceptions;

namespace MMS.Modules.Nationalities.Core.ValueObjects;

public record PanchayathName
{
    public string Value { get; }
        
    public PanchayathName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 100 or < 3)
        {
            throw new InvalidPanchayathNameException(value);
        }
            
        Value = value;
    }

    public static implicit operator PanchayathName(string value) => value is null ? null : new PanchayathName(value);

    public static implicit operator string(PanchayathName value) => value?.Value;

    public override string ToString() => Value;
}