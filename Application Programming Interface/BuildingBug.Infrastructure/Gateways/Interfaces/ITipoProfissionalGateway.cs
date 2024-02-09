using BuildingBug.Domain.Model;

namespace BuildingBug.Infrastructure.Gateways.Interfaces
{

    public interface ITipoProfissionalGateway
    {
        public Task<bool> CreateTipoProfissional(TipoProfissional tipoProfissional);
        public Task<bool> UpdateTipoProfissional(TipoProfissional tipoProfissional);
        public Task<bool> DeleteTipoProfissional(int tipoId, int profissionalId);
        public Task<TipoProfissional> GetTipoProfissional(int tipoId, int profissionalId);
        public Task<IEnumerable<TipoProfissional>> GetAllTiposProfissional();
    }
}

