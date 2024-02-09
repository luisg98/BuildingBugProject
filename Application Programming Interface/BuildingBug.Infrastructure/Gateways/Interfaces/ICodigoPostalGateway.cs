using BuildingBug.Domain.Model;

namespace BuildingBug.Infrastructure.Gateways.Interfaces
{
    public interface ICodigoPostalGateway
    {
        public Task<bool> CreateCodigoPostal(CodigoPostal codigoPostal);
        public Task<bool> UpdateCodigoPostal(CodigoPostal codigoPostal);
        public Task<bool> DeleteCodigoPostal(int cp);
        public Task<CodigoPostal> GetCodigoPostal(int cp);
        public Task<IEnumerable<CodigoPostal>> GetAllCodigosPostais();
    }
}
