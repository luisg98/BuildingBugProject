using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface IProfissionalService
    {

        public Task<Profissional> GetProfissionalLogin(string email, string password);

        public Task<bool> CreateProfissional(Profissional profissional);

        public Task<bool> UpdateProfissional(Profissional profissional);

        public Task<bool> DeleteProfissional(int id);

        public Task<Profissional> GetProfissional(int id);

        public Task<IEnumerable<Profissional>> GetAllProfissionais();
    }
}