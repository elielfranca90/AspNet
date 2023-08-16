using Microsoft.AspNetCore.Mvc;
using MinhaApi.Data;
using MinhaApi.Models;

namespace Todo.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public List<TodoModel> Get(
            [FromServices]AppDbContext context
        )
        {
            //Nota[AppDbContext FromServices]: como adc. o service em Program.cs, 
            //é possível utilizar dessa maneira aqui via Injeção de Dependência

            return context.Todos.ToList();
        }
    }
    
}