using MMS.Modules.Nationalities.Core.ValueObjects;

namespace MMS.Modules.Nationalities.Core.Entities;

internal sealed class Panchayath
{
    public Guid Id { get; private set; }
    public PanchayathName Name { get; private set; }
    public Guid MadalamId { get; private set; }
    public Madalam Madalam { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsDeleted { get; private set; }
    
    public Panchayath(Guid id, PanchayathName name, Guid madalamId, DateTime createdAt)
    {
        Id = id;
        Name = name;
        MadalamId = madalamId;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    
    public void  Update(PanchayathName name, Guid madalamId, bool isArea)
    {
        Name = name;
        MadalamId = madalamId;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}