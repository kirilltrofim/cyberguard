using Kiber.Application.Common;
using Kiber.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
    opt.UseInMemoryDatabase("kiber"));

builder.Services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<ApplicationDbContext>());

builder.Services.AddAutoMapper(typeof(Kiber.Application.Participants.ParticipantProfile));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Kiber.Application.Participants.Queries.GetParticipantsQuery>());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();

public partial class Program;
