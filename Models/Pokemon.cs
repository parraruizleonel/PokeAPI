namespace PokeAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }  // Identificador único para cada Pokémon
        public string Name { get; set; }  // Nombre del Pokémon
        public string Type { get; set; }  // Tipo del Pokémon (ej. "Electric")
        public string Abilities { get; set; }  // Habilidades del Pokémon
    }
}
