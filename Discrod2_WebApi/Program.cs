var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); //  Para que funcionen los controladores
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS: Permitir cualquier origen, cabecera y método (ideal para desarrollo)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Configurar app
var app = builder.Build();

// Habilita Swagger (documentación automática)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi(); // si lo estás usando desde AddOpenApi
}

// Archivos estáticos desde wwwroot
app.UseStaticFiles();

// CORS debe ir antes de MapControllers()
app.UseCors();

app.UseHttpsRedirection();

// Mapear los controladores de API
app.MapControllers();

// Endpoint de prueba
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
