using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface IDeslocacaoService
    {
        public Task<bool> CreateDeslocacao(Deslocacao deslocacao);
        public Task<bool> UpdateDeslocacao(Deslocacao deslocacao);
        public Task<bool> DeleteDeslocacao(int id);
        public Task<Deslocacao> GetDeslocacao(int id);
        public Task<IEnumerable<Deslocacao>> GetAllDeslocacoes();
    }
}
