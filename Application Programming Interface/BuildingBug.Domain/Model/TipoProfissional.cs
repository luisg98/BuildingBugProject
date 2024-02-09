using System.Text.Json.Serialization;

namespace BuildingBug.Domain.Model
{
    public class TipoProfissional
    {
        [JsonPropertyName("tipo_id")]
        public int TipoId { get; set; }

        [JsonPropertyName("profissional_id")]
        public int ProfissionalId { get; set; }


    }
}
