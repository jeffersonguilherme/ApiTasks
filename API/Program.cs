using Application.UserCQ.Commands;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TasksDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(CreateUserCommands).Assembly));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(); // Mantém a UI em /swagger

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
