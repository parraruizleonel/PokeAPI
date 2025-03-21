using Microsoft.EntityFrameworkCore;  // Para trabajar con Entity Framework
using PokeAPI.Data;  // Para usar ApplicationDbContext
using PokeAPI.Models;  // Para usar el modelo Pokemon

namespace PokeAPI.Repositories
{
    public class PokemonRepository
    {
        private readonly ApplicationDbContext _context;

        public PokemonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Crear un Pokémon
        public async Task<Pokemon> CreateAsync(Pokemon pokemon)
        {
            _context.Pokemons.Add(pokemon);
            await _context.SaveChangesAsync();
            return pokemon;
        }

        // Obtener un Pokémon por nombre
        public async Task<Pokemon?> GetAsync(string name)
        {
            return await _context.Pokemons.FirstOrDefaultAsync(p => p.Name == name);
        }

        // Obtener todos los Pokémon
        public async Task<List<Pokemon>> GetAllAsync()
        {
            return await _context.Pokemons.ToListAsync();
        }

        // Actualizar un Pokémon por Id
        public async Task<Pokemon?> UpdateAsync(int id, Pokemon updatedPokemon)
        {
            var pokemon = await _context.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
            if (pokemon == null)
                return null;

            pokemon.Name = updatedPokemon.Name;
            pokemon.Type = updatedPokemon.Type;
            pokemon.Abilities = updatedPokemon.Abilities;

            await _context.SaveChangesAsync();
            return pokemon;
        }

        // Eliminar un Pokémon por Id
        public async Task<bool> DeleteAsync(int id)
        {
            var pokemon = await _context.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
            if (pokemon == null)
                return false;

            _context.Pokemons.Remove(pokemon);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
