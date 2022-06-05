namespace MMS.Modules.Nationalities.Shared.DTO;

public class MadalamDto
{
    public Guid Id { get; set; }
    public string ShortCode { get; set; }
    public string Name { get; set; }
    public Guid DistrictId { get; set; }
    public string DistrictName { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsArea { get; set; }
    public DateTime CreatedAt { get; set; }
}