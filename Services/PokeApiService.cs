using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeAPI.Services
{
    public class PokeApiService
    {
        private readonly HttpClient _httpClient;

        public PokeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetPokemonAsync(string name)
        {
            // Corregido: Usar interpolación de cadenas sin barras invertidas
            var response = await _httpClient.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
            return response;
        }
    }
}
