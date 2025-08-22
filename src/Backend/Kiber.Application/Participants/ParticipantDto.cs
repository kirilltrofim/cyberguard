namespace Kiber.Application.Participants;

public record ParticipantDto(Guid Id, string Nick, int TasksCompletedCount, int Currency);
