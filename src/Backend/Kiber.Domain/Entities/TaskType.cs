namespace Kiber.Domain.Entities;

public class TaskType
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? IconUrl { get; set; }
}
