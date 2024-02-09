using System.Text.Json.Serialization;

namespace BuildingBug.Domain.Model
{
    public class ServicoDTO
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

        [JsonPropertyName("nome_cliente")]
        public string NomeCliente { get; set; }

        [JsonPropertyName("estadoServico")]
        public string EstadoServico { get; set; }

        [JsonPropertyName("codigoPostalCP")]
        public int CodigoPostalCP { get; set; }

        [JsonPropertyName("nome_profissional")]
        public string NomeProfissional { get; set; }

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }
    }
}