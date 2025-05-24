var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(); // Mantém a UI em /swagger

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
