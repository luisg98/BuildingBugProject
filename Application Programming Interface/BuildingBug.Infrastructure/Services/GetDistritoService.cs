using Newtonsoft.Json;

namespace BuildingBug.Infrastructure.Services
{
    public class GetDistritoService
    {
        private readonly HttpClient _httpClient;


        public GetDistritoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDistritoAsync(string latitude, string longitude)
        {
            var url = $"https://json.geoapi.pt/gps/{latitude},{longitude}";

            try
            {
                var response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var geoApiResponse = JsonConvert.DeserializeObject<GeoApiResponse>(content);
                    Console.WriteLine(geoApiResponse);
                    return geoApiResponse?.distrito;
                }
                else
                {
                    // Handle the case where the API does not return a success status code
                    throw new Exception($"Chamada a API falhou. Código: {response.StatusCode}");
                }
            }
            catch (HttpRequestException e)
            {
                // Handle any errors that occur during the call to the API
                throw new Exception("Erro ao chamar a GeoAPI.pt", e);
            }
        }
    }


    public class GeoApiResponse
    {
        public double lon { get; set; }
        public double lat { get; set; }
        public string distrito { get; set; }
        public string concelho { get; set; }
        public string freguesia { get; set; }
        public string uso { get; set; }
        public string SEC { get; set; }
        public string SS { get; set; }
        public string rua { get; set; }
        public string n_porta { get; set; }
        public string CP { get; set; }
        public int altitude_m { get; set; }
    }
}
