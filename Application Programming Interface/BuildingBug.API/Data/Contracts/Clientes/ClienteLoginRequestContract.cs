using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Clientes
{
    public class ClienteLoginRequestContract
    {
        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
