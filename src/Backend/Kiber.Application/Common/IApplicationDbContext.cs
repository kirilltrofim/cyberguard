using Microsoft.EntityFrameworkCore;
using Kiber.Domain.Entities;

namespace Kiber.Application.Common;

public interface IApplicationDbContext
{
    DbSet<Participant> Participants { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
