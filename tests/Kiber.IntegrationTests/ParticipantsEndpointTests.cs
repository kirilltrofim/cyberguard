using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using Xunit;

namespace Kiber.IntegrationTests;

public class ParticipantsEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ParticipantsEndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetParticipants_ReturnsOk()
    {
        var response = await _client.GetAsync("/api/v1/participants");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}
