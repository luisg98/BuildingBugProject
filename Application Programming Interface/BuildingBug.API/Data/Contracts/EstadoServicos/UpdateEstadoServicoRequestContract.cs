using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.EstadoServico
{
    public class UpdateEstadoServicoRequestContract
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

    }
}
