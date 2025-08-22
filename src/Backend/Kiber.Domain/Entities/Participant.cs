namespace Kiber.Domain.Entities;

public class Participant
{
    public Guid Id { get; set; }
    public string Nick { get; set; } = string.Empty;
    public long? TelegramId { get; set; }
    public string? TelegramLink { get; set; }
    public DateTime? LastActiveAt { get; set; }
    public DateTime RegisteredAt { get; set; }
    public int TasksCompletedCount { get; set; }
    public Guid? RankId { get; set; }
    public int RankProgress { get; set; }
    public int Currency { get; set; }
    public string? Phone { get; set; }
    public bool PhoneConfirmed { get; set; }
    public string? Gender { get; set; }
    public ParticipantStatus Status { get; set; } = ParticipantStatus.Active;
    public string? CityCode { get; set; }
    public Guid? AvatarAssetId { get; set; }
    public Guid? FrameAssetId { get; set; }
    public string ReferralCode { get; set; } = string.Empty;
    public Guid? ReferredByParticipantId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public enum ParticipantStatus
{
    Active,
    Banned
}
