namespace Kiber.Domain.Entities;

public class SeasonPass
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? BackgroundUrl { get; set; }
    public string? FrameUrl { get; set; }
    public int LevelsCount { get; set; }
    public int StepPoints { get; set; }
    public int RewardCoinsPerLevel { get; set; }
    public Guid? RewardAssetId { get; set; }
    public string? Description { get; set; }
    public DateTime StartsAt { get; set; }
    public DateTime EndsAt { get; set; }
    public SeasonStatus Status { get; set; }
}

public enum SeasonStatus
{
    Draft,
    Active,
    Archived
}
