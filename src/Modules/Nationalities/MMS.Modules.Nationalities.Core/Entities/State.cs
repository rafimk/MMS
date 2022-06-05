using MMS.Modules.Nationalities.Core.ValueObjects;

namespace MMS.Modules.Nationalities.Core.Entities;

internal sealed class State
{
    public Guid Id { get; private set; }
    public string ShortCode { get; private set; }
    public StateName Name { get; private set; }
    public Guid CountryId { get; private set; }
    public Country Country { get;  }
    public bool IsDeleted { get; private set; }
    public bool IsArea { get; private set; }
    public DateTime CreatedAt { get; private set; }
  
    
    public State(Guid id, string shortCode, StateName name, Guid countryId, bool isArea, DateTime createdAt)
    {
        Id = id;
        ShortCode = shortCode;
        Name = name;
        CountryId = countryId;
        IsArea = isArea;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    
    public void  Update(string shortCode, StateName name, Guid countryId, bool isArea)
    {
        ShortCode = shortCode;
        Name = name;
        CountryId = countryId;
        IsArea = isArea;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}