namespace MMS.Modules.Nationalities.Shared.DTO;

public class PanchayathDto
{
    public Guid Id { get; set; }
    public string ShortCode { get; set; }
    public string Name { get; set; }
    public Guid MadalamId { get; set; }
    public string MadalamName { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsArea { get; set; }
    public DateTime CreatedAt { get; set; }
}