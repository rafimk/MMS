using MMS.Modules.Nationalities.Core.ValueObjects;

namespace MMS.Modules.Nationalities.Core.Entities;

internal sealed class Madalam
{
    public Guid Id { get; private set; }
    public MadalamName Name { get; private set; }
    public Guid DistrictId { get; private set; }
    public District District { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsDeleted { get; private set; }
    
    public Madalam(Guid id, MadalamName name, Guid districtId, DateTime createdAt)
    {
        Id = id;
        Name = name;
        DistrictId = districtId;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    
    public void  Update(MadalamName name, Guid districtId, bool isArea)
    {
        Name = name;
        DistrictId = districtId;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}