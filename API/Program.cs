using Application.CardCQ;
using Application.UserCQ.Commands;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TasksDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(CreateUserCommand).Assembly));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(CreateCardCommand).Assembly));
builder.Services.AddValidatorsFromAssemblyContaining<>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(); // Mantém a UI em /swagger

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
