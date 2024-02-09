using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Servicos
{
    public class CreateServicoRequestContract
    {
        [Required]
        [JsonPropertyName("morada")]
        public string Morada { get; set; }

        [Required]
        [JsonPropertyName("fator")]
        public int Fator { get; set; }

        [Required]
        [JsonPropertyName("clienteId")]
        public int ClienteId { get; set; }

        [Required]
        [JsonPropertyName("codigoPostalCP")]
        public int CodigoPostalCP { get; set; }

        [Required]
        [JsonPropertyName("tipoId")]
        public int TipoId { get; set; }

    }
}
