namespace Kiber.Domain.Entities;

public class WeeklyQuestLog
{
    public Guid ParticipantId { get; set; }
    public DateOnly WeekStart { get; set; }
    public bool Login5Times { get; set; }
    public bool Completed5TasksType1 { get; set; }
    public bool Completed5TasksType2 { get; set; }
}
