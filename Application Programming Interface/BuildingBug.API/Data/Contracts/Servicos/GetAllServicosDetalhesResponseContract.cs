using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Servicos
{
    public class GetAllServicosDetalhesResponseContract
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
        [JsonPropertyName("custo")]
        public float Custo { get; set; }

        [Required]
        [JsonPropertyName("fator")]
        public int Fator { get; set; }

        [Required]
        [JsonPropertyName("inactive")]
        public bool Inactive { get; set; }

        [Required]
        [JsonPropertyName("nome_cliente")]
        public string NomeCliente { get; set; }

        [Required]
        [JsonPropertyName("estado_servico")]
        public string EstadoServico { get; set; }

        [Required]
        [JsonPropertyName("codigoPostalCP")]
        public int CodigoPostalCP { get; set; }

        [Required]
        [JsonPropertyName("nome_profissional")]
        public string NomeProfissional { get; set; }

        [Required]
        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }
    }
}
