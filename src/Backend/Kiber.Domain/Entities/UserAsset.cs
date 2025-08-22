namespace Kiber.Domain.Entities;

public class UserAsset
{
    public Guid ParticipantId { get; set; }
    public Guid AssetId { get; set; }
    public bool IsActive { get; set; }
    public DateTime? AssignedAt { get; set; }
}
