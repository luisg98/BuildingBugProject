using BuildingBug.Domain.Model;

namespace BuildingBug.Infrastructure.Gateways.Interfaces
{
    public interface IProfissionalGateway
    {
        public Task<Profissional> GetProfissionalLogin(string email);
        public Task<bool> CreateProfissional(Profissional profissional);

        public Task<bool> UpdateProfissional(Profissional profissional);

        public Task<bool> DeleteProfissional(int id);

        public Task<Profissional> GetProfissional(int id);

        public Task<IEnumerable<Profissional>> GetAllProfissionais();
    }
}
