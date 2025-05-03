var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet(
        "/say-hi/{name}",
        (string name) =>
        {
            return Results.Ok(new { Message = $"Hi {name}!" });
        }
    )
    .WithName("SayHi");

app.Run();
