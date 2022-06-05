using MMS.Modules.Nationalities.Core.ValueObjects;

namespace MMS.Modules.Nationalities.Core.Entities;

internal sealed class District
{
    public Guid Id { get; private set; }
    public DistrictName Name { get; private set; }
    public Guid StateId { get; private set; }
    public State State { get;  }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }
  
    
    public District(Guid id, DistrictName name, Guid stateId, DateTime createdAt)
    {
        Id = id;
        Name = name;
        StateId = stateId;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    
    public void  Update(DistrictName name, Guid stateId, bool isArea)
    {
        Name = name;
        StateId = stateId;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}