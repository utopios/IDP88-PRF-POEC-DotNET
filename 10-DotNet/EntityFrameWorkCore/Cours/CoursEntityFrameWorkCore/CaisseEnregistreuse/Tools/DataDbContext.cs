using CaisseEnregistreuse.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Tools
{
    public class DataDbContext : DbContext
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ReposM2i\IDP88-PRF-POEC-DotNET\10-DotNet\EntityFrameWorkCore\Cours\cours.mdf;Integrated Security=True;Connect Timeout=30";

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
