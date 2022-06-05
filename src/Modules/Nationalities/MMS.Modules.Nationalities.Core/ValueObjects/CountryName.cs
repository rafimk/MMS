using MMS.Modules.Nationalities.Core.Exceptions;

namespace MMS.Modules.Nationalities.Core.ValueObjects;

public record CountryName
{
    public string Value { get; }
        
    public CountryName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 100 or < 3)
        {
            throw new InvalidCountryNameException(value);
        }
            
        Value = value;
    }

    public static implicit operator CountryName(string value) => value is null ? null : new CountryName(value);

    public static implicit operator string(CountryName value) => value?.Value;

    public override string ToString() => Value;
}