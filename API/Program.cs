using Infra.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TasksDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(); // Mantém a UI em /swagger

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
