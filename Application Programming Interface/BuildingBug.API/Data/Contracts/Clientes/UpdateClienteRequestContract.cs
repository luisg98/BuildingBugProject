using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Clientes
{
    public class UpdateClienteRequestContract
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [Required]
        [JsonPropertyName("apelido")]
        public string Apelido { get; set; }

        [Required]
        [JsonPropertyName("contacto")]
        public int Contacto { get; set; }


    }
}
