using Kiber.Application.Common;
using Kiber.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kiber.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Participant> Participants => Set<Participant>();

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken) => base.SaveChangesAsync(cancellationToken);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Participant>(b =>
        {
            b.HasKey(p => p.Id);
            b.HasIndex(p => p.TelegramId);
            b.HasIndex(p => p.Status);
            b.Property(p => p.Nick).HasMaxLength(100);
        });
    }
}
