namespace Kiber.Domain.Entities;

public class ReferralRelation
{
    public Guid ParentParticipantId { get; set; }
    public Guid ChildParticipantId { get; set; }
    public DateTime LinkedAt { get; set; }
}
