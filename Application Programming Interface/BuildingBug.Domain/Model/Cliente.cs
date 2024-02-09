using System.Text.Json.Serialization;

namespace BuildingBug.Domain.Model
{
    public class Cliente
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("apelido")]
        public string Apelido { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("senha")]
        public string Senha { get; set; }

        [JsonPropertyName("contacto")]
        public int Contacto { get; set; }

        [JsonPropertyName("inactive")]
        public bool? Inactive { get; set; }
    }
}
