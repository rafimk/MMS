using MMS.Modules.Nationalities.Core.Exceptions;

namespace MMS.Modules.Nationalities.Core.ValueObjects;

public record MadalamName
{
    public string Value { get; }
        
    public MadalamName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 100 or < 3)
        {
            throw new InvalidMadalamNameException(value);
        }
            
        Value = value;
    }

    public static implicit operator MadalamName(string value) => value is null ? null : new MadalamName(value);

    public static implicit operator string(MadalamName value) => value?.Value;

    public override string ToString() => Value;
}