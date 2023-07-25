using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

#region Mapping

app.MapGet("/HealthCheck", () => 
{
    return Results.Ok("HelloWorld. I'm OK ;)");
});

app.MapGet("/{msg}", async (string msg) => 
{
    return Results.Ok(msg);
});

app.MapPost("/User/{user}", (User user) =>{
    return Results.Ok(user);
});

#endregion

app.Run();
public class User
{
    public int Id { get; set; }
    public string UserName { get; set;}
}

