using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Clientes
{
    public class ClienteLoginResponseContract
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
