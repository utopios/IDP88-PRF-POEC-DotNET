
using LePendu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePendu.Tools
{
    public class DataDbContext : DbContext
    {

        public DbSet<Word> Words { get; set; }
        public DbSet<PenduUser> Users { get; set; }
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ReposM2i\IDP88-PRF-POEC-DotNET\10-DotNet\EntityFrameWorkCore\Cours\cours.mdf;Integrated Security=True;Connect Timeout=30";

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
