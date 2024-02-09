using System.Text.Json.Serialization;

namespace BuildingBug.Domain.Model
{
    public class Servico
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("morada")]
        public string Morada { get; set; }

        [JsonPropertyName("dataInicio")]
        public DateTime DataInicio { get; set; }

        [JsonPropertyName("dataFim")]
        public DateTime DataFim { get; set; }

        [JsonPropertyName("avaliacao")]
        public int Avaliacao { get; set; }

        [JsonPropertyName("custo")]
        public float Custo { get; set; }

        [JsonPropertyName("fator")]
        public int Fator { get; set; }

        [JsonPropertyName("inactive")]
        public bool Inactive { get; set; }

        [JsonPropertyName("clienteId")]
        public int ClienteId { get; set; }

        [JsonPropertyName("estadoServicoId")]
        public int EstadoServicoId { get; set; }

        [JsonPropertyName("codigoPostalCP")]
        public int CodigoPostalCP { get; set; }

        [JsonPropertyName("profissionalId")]
        public int ProfissionalId { get; set; }

        [JsonPropertyName("tipoId")]
        public int TipoId { get; set; }
    }
}