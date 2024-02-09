using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Deslocacoes
{
    public class CreateDeslocacaoRequestContract
    {
        [JsonPropertyName("data")]
        public DateTime Data { get; set; }

        [JsonPropertyName("servico_id")]
        public int ServicoId { get; set; }

        [JsonPropertyName("detalhes")]
        public string Detalhes { get; set; }
    }
}