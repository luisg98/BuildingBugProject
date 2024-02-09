using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Tipos
{
    public class UpdateTipoRequestContract
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("preco")]
        public int Preco { get; set; }

        [JsonPropertyName("fator")]
        public bool Fator { get; set; }

        [JsonPropertyName("categoria")]
        public string Categoria { get; set; }

    }
}
