using Microsoft.EntityFrameworkCore;
using web_api_pokemon.Models;

namespace web_api_pokemon.Tools;

public class DataBaseContext : DbContext
{
    public DbSet<RoleApp> Roles { get; set; }
    public DbSet<UserApp> Users { get; set; }
    public DbSet<Pokemon?> Pokemons { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=tcp:m2i-bdd-server.database.windows.net,1433;Initial Catalog=bdd-guillaume;Persist Security Info=False;User ID=m2iformation;Password=Utopios.123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}