using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.EstadoServico
{
    public class CreateEstadoServicoRequestContract
    {
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
    }
}