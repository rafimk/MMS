using MMS.Modules.Nationalities.Core.ValueObjects;

namespace MMS.Modules.Nationalities.Core.Entities;

internal sealed class Country
{
    public Guid Id { get; private set; }
    public string ShortCode { get; private set; }
    public CountryName Name { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsDeleted { get; private set; }

    public Country(Guid id, string shortCode,CountryName name, DateTime createdAt)
    {
        Id = id;
        ShortCode = shortCode;
        Name = name;
        CreatedAt = createdAt;
        IsDeleted = false;
    }

    public void Update(string shortCode,CountryName name)
    {
        ShortCode = shortCode;
        Name = name;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}