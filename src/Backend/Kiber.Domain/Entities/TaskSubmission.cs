namespace Kiber.Domain.Entities;

public class TaskSubmission
{
    public Guid Id { get; set; }
    public Guid TaskId { get; set; }
    public Guid ParticipantId { get; set; }
    public string Text { get; set; } = string.Empty;
    public string? ScreenshotUrl { get; set; }
    public SubmissionStatus Status { get; set; }
    public Guid? ModeratorId { get; set; }
    public string? ModeratorComment { get; set; }
    public DateTime SubmittedAt { get; set; }
    public DateTime? ReviewedAt { get; set; }
}

public enum SubmissionStatus
{
    Pending,
    Approved,
    Rejected
}
