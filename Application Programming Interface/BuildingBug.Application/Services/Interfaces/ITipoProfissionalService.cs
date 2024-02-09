using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface ITipoProfissionalService
    {
        public Task<bool> CreateTipoProfissional(TipoProfissional tipoProfissional);
        public Task<bool> UpdateTipoProfissional(TipoProfissional tipoProfissional);
        public Task<bool> DeleteTipoProfissional(int tipoId, int profissionalId);
        public Task<TipoProfissional> GetTipoProfissional(int tipoId, int profissionalId);
        public Task<IEnumerable<TipoProfissional>> GetAllTiposProfissional();


    }
}
