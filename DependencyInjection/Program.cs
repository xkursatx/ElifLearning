using DependencyInjection.Servicelerim;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<BenimServisim>();

var app = builder.Build();

app.MapControllers();
await app.RunAsync();