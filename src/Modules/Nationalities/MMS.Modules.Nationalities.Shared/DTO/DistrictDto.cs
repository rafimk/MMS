namespace MMS.Modules.Nationalities.Shared.DTO;

public class DistrictDto
{
    public Guid Id { get; set; }
    public string ShortCode { get; set; }
    public string Name { get; set; }
    public Guid StateId { get; set; }
    public string StateName { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsArea { get; set; }
    public DateTime CreatedAt { get; set; }
}