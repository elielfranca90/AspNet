using Microsoft.AspNetCore.Http.HttpResults;
using MinhaApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //Adc. suporte aos controllers da app

//Contexto da base de dados agora como serviço para ser utilizado na APP
//Dessa forma o próprio APSNET vai gerenciar a criação e destriução do objeto
builder.Services.AddDbContext<AppDbContext>(); 

var app = builder.Build();

#region Mapping

//app.MapGet("/HealthCheck", () => 
//{
//    return Results.Ok("HelloWorld. I'm OK ;)");
//});
//
//app.MapGet("/{msg}", (string msg) => 
//{
//    return Results.Ok(msg);
//});

//app.MapPost("/User/{user}", (User user) =>{
    //return Results.Ok(user);
//});

#endregion

app.MapControllers();

app.Run();

