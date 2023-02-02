using CaisseEnregistreuse.Models;
using Microsoft.EntityFrameworkCore;

namespace CaisseEnregistreuse.Tools
{
    public class DataDbContext : DbContext
    {
        public DbSet<Product> Products { get;set; } 
        public DbSet<Category> Categories { get;set; }
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ReposM2i\IDP88-PRF-POEC-DotNET\10-DotNet\EntityFrameWorkCore\Cours\cours.mdf;Integrated Security=True;Connect Timeout=30";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
