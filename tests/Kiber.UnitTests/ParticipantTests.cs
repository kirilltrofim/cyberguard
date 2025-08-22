using FluentAssertions;
using Kiber.Domain.Entities;
using Xunit;

namespace Kiber.UnitTests;

public class ParticipantTests
{
    [Fact]
    public void CreateParticipant_ShouldSetDefaults()
    {
        var p = new Participant { Nick = "test" };
        p.Nick.Should().Be("test");
        p.Status.Should().Be(ParticipantStatus.Active);
    }
}
