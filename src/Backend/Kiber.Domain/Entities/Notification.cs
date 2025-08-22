namespace Kiber.Domain.Entities;

public class Notification
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public DateTime ScheduleAt { get; set; }
    public Guid CreatedBy { get; set; }
    public NotificationStatus Status { get; set; }
    public string Target { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}

public enum NotificationStatus
{
    Scheduled,
    Sent
}
