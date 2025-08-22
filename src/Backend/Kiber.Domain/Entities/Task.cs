namespace Kiber.Domain.Entities;

public class Task
{
    public Guid Id { get; set; }
    public Guid TaskTypeId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartsAt { get; set; }
    public DateTime EndsAt { get; set; }
    public int RewardCoins { get; set; }
    public int RewardExp { get; set; }
    public int RewardBattlePassPoints { get; set; }
    public TaskStatus Status { get; set; }
    public bool RequiresReview { get; set; }
    public DateTime CreatedAt { get; set; }
}

public enum TaskStatus
{
    Active,
    Archived
}
