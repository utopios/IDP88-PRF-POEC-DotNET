using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\ReposM2i\\IDP88-PRF-POEC-DotNET\\10-DotNet\\EntityFrameWorkCore\\Cours\\cours.mdf;Integrated Security=True;Connect Timeout=30");
        //}

        public DbSet<Contact> Contacts { get; set; }
    }
}
