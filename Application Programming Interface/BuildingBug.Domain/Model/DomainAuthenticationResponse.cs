namespace BuildingBug.Domain.Model
{
    public class DomainAuthenticationResponse
    {
        public string Token { get; set; }

        public DateTime Expiration { get; set; }
    }
}
