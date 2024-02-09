using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Clientes
{
    public class CreateClienteResponseContract
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
