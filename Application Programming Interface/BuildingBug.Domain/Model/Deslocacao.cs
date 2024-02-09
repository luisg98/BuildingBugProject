using System.Text.Json.Serialization;

namespace BuildingBug.Domain.Model
{
    public class Deslocacao
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("data")]
        public DateTime Data { get; set; }

        [JsonPropertyName("servico_id")]
        public int ServicoId { get; set; }

        [JsonPropertyName("detalhes")]
        public string Detalhes { get; set; }
    }
}