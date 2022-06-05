using MMS.Modules.Nationalities.Core.Exceptions;

namespace MMS.Modules.Nationalities.Core.ValueObjects;

public record StateName
{
    public string Value { get; }
        
    public StateName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 100 or < 3)
        {
            throw new InvalidStateNameException(value);
        }
            
        Value = value;
    }

    public static implicit operator StateName(string value) => value is null ? null : new StateName(value);

    public static implicit operator string(StateName value) => value?.Value;

    public override string ToString() => Value;
}