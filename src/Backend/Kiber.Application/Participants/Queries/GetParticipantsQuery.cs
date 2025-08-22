using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kiber.Application.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Kiber.Application.Participants.Queries;

public record GetParticipantsQuery(int Page = 1, int Size = 10) : IRequest<IReadOnlyList<ParticipantDto>>;

public class GetParticipantsHandler : IRequestHandler<GetParticipantsQuery, IReadOnlyList<ParticipantDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetParticipantsHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<ParticipantDto>> Handle(GetParticipantsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Participants
            .OrderBy(x => x.Nick)
            .Skip((request.Page - 1) * request.Size)
            .Take(request.Size)
            .ProjectTo<ParticipantDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
