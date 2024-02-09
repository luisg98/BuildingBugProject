using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Servicos
{
    public class CreateServicoResponseContract
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
