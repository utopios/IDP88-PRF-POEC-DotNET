using PizzCore.Models;
using PizzCore.Datas;
using Microsoft.EntityFrameworkCore;

namespace PizzAPI.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(InitialPizza.pizzas);
            modelBuilder.Entity<Ingredient>().HasData(InitialPizza.ingredients);
        }
    }
}
