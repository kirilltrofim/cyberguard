using Kiber.Application.Participants;
using Kiber.Application.Participants.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Kiber.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ParticipantsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ParticipantsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IReadOnlyList<ParticipantDto>> Get([FromQuery] int page = 1, [FromQuery] int size = 10)
        => await _mediator.Send(new GetParticipantsQuery(page, size));
}
