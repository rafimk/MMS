namespace MMS.Modules.Nationalities.Shared.DTO;

public class StateDto
{
    public Guid Id { get; set; }
    public string ShortCode { get; set; }
    public string Name { get; set; }
    public Guid CountryId { get; set; }
    public string CountryName { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsArea { get; set; }
    public DateTime CreatedAt { get; set; }
}