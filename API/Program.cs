using API;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.AddServices();
builder.AddDatabase();
builder.AddValidations();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(); // Mantém a UI em /swagger

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
