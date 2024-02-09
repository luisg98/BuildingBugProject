using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Servicos
{
    public class UpdateServicoRequestContract
    {
        [Required]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonPropertyName("morada")]
        public string Morada { get; set; }

        [Required]
        [JsonPropertyName("dataInicio")]
        public DateTime DataInicio { get; set; }

        [Required]
        [JsonPropertyName("dataFim")]
        public DateTime DataFim { get; set; }

        [Required]
        [JsonPropertyName("avaliacao")]
        public int Avaliacao { get; set; }

        [Required]
        [JsonPropertyName("custo")]
        public float Custo { get; set; }

        [Required]
        [JsonPropertyName("fator")]
        public int Fator { get; set; }

        [Required]
        [JsonPropertyName("clienteId")]
        public int ClienteId { get; set; }

        [Required]
        [JsonPropertyName("estadoServicoId")]
        public int EstadoServicoId { get; set; }

        [Required]
        [JsonPropertyName("codigoPostalCP")]
        public int CodigoPostalCP { get; set; }

        [Required]
        [JsonPropertyName("profissionalId")]
        public int ProfissionalId { get; set; }

        [Required]
        [JsonPropertyName("tipoId")]
        public int TipoId { get; set; }


    }
}
