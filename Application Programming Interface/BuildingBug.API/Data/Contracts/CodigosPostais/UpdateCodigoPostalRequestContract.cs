using System.Text.Json.Serialization;

namespace BuildingBug.API.Data.Contracts.CodigosPostais
{
    public class UpdateCodigoPostalRequestContract
    {
        [JsonPropertyName("cp")]
        public int CP { get; set; }

        [JsonPropertyName("distrito")]
        public string Distrito { get; set; }

    }
}
