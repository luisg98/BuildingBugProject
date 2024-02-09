using System.Text.Json.Serialization;

namespace BuildingBug.Domain.Model
{
    public class EstadoServico
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

    }
}