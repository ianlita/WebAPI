using Scalar.AspNetCore;
using WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IPostService, PostService>();    

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); // This will add the Scalar API reference to the OpenAPI documentation
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
