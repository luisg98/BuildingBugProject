using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Clientes
{
    public class GetClienteResponseContract
    {
        [Required]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [Required]
        [JsonPropertyName("apelido")]
        public string Apelido { get; set; }

        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("senha")]
        public string Senha { get; set; }

        [Required]
        [JsonPropertyName("contacto")]
        public int Contacto { get; set; }

        [Required]
        [JsonPropertyName("inactive")]
        public bool? Inactive { get; set; }
    }
}
