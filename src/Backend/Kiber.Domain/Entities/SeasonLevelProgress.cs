namespace Kiber.Domain.Entities;

public class SeasonLevelProgress
{
    public Guid ParticipantId { get; set; }
    public Guid SeasonPassId { get; set; }
    public int CurrentPoints { get; set; }
    public int CurrentLevel { get; set; }
}
