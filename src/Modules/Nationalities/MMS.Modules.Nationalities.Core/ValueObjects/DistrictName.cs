using MMS.Modules.Nationalities.Core.Exceptions;

namespace MMS.Modules.Nationalities.Core.ValueObjects;

public record DistrictName
{
    public string Value { get; }
        
    public DistrictName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 100 or < 3)
        {
            throw new InvalidDistrictNameException(value);
        }
            
        Value = value;
    }

    public static implicit operator DistrictName(string value) => value is null ? null : new DistrictName(value);

    public static implicit operator string(DistrictName value) => value?.Value;

    public override string ToString() => Value;
}