using AutoMapper;
using Kiber.Domain.Entities;

namespace Kiber.Application.Participants;

public class ParticipantProfile : Profile
{
    public ParticipantProfile()
    {
        CreateMap<Participant, ParticipantDto>();
    }
}
