using DinoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DinoAPI.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Dinosaur> Dinosaurs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
