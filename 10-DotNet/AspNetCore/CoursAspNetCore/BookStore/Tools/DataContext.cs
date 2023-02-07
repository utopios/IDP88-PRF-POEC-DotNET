using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Tools
{
    public class DataContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserApp> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ReposM2i\IDP88-PRF-POEC-DotNET\10-DotNet\AspNetCore\CoursAspNetCore\BookStore\data.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
