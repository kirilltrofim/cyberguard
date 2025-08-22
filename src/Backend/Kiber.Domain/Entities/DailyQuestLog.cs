namespace Kiber.Domain.Entities;

public class DailyQuestLog
{
    public Guid ParticipantId { get; set; }
    public DateOnly Date { get; set; }
    public bool DailyLogin { get; set; }
    public bool Completed1Task { get; set; }
    public bool Completed3Tasks { get; set; }
}
