namespace Kiber.Domain.Entities;

public class Rank
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RequiredExp { get; set; }
    public int DisplayOrder { get; set; }
}
