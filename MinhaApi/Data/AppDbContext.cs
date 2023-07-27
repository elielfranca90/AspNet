using Microsoft.EntityFrameworkCore;
using MinhaApi.Models;

namespace MinhaApi.Data
{
    public class AppDbContext : DbContext // DbContext = representação do banco de dados
    {
        public DbSet<TodoModel> Todos { get; set; } // DbSet = representação de uma tabela

        //Conection String
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}