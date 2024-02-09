using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.Profissionais
{
    public class ProfissionalLoginResponseContract
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
