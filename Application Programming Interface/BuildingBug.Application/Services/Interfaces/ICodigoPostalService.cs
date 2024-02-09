using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface ICodigoPostalService
    {
        public Task<bool> CreateCodigoPostal(CodigoPostal codigoPostalCP);
        public Task<bool> UpdateCodigoPostal(CodigoPostal codigoPostalCP);
        public Task<bool> DeleteCodigoPostal(int cp);
        public Task<CodigoPostal> GetCodigoPostal(int cp);
        public Task<IEnumerable<CodigoPostal>> GetAllCodigosPostais();
    }
}
