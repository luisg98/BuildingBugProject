using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.TiposProfissional
{
    public class CreateTipoProfissionalRequestContract
    {
        [JsonPropertyName("tipo_id")]
        public int TipoId { get; set; }

        [JsonPropertyName("profissional_id")]
        public int ProfissionalId { get; set; }
    }
}
