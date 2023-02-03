using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Tools
{
    public class DataDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ReposM2i\IDP88-PRF-POEC-DotNET\10-DotNet\EntityFrameWorkCore\Cours\cours.mdf;Integrated Security=True;Connect Timeout=30";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
