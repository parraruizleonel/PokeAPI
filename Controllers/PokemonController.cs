using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PokeAPI.Services;
using System.Threading.Tasks;

namespace PokeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokeApiService _pokeApiService;

        public PokemonController(PokeApiService pokeApiService)
        {
            _pokeApiService = pokeApiService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetPokemonAsync(string name)
        {
            // Llamada al servicio para obtener los datos del Pokémon
            var json = await _pokeApiService.GetPokemonAsync(name);

            // Convertimos la respuesta JSON a un objeto JObject para manejar los datos
            var pokemonData = JObject.Parse(json);

            // Extraemos los datos del Pokémon de manera segura
            var result = new
            {
                Name = pokemonData["name"]?.ToString(),
                BaseExperience = pokemonData["base_experience"]?.ToString(),
                Abilities = pokemonData["abilities"] != null ? pokemonData["abilities"].Select(a => a["ability"]?["name"]?.ToString()).ToList() : new List<string>(),
                Height = pokemonData["height"]?.ToString(),
                Weight = pokemonData["weight"]?.ToString()
            };

            return Ok(result);
        }
    }
}
