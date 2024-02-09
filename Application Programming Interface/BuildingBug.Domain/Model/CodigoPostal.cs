using System.Text.Json.Serialization;

namespace BuildingBug.Domain.Model
{
    public class CodigoPostal
    {
        [JsonPropertyName("cp")]
        public int CP { get; set; }

        [JsonPropertyName("distrito")]
        public string Distrito { get; set; }


    }
}