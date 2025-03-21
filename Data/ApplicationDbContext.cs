using Microsoft.EntityFrameworkCore;
using PokeAPI.Models;

namespace PokeAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> Pokemons { get; set; }  // DbSet para Pokémon
    }
}
