using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface IEstadoServicoService
    {
        public Task<bool> CreateEstadoServico(EstadoServico estadoServico);
        public Task<bool> UpdateEstadoServico(EstadoServico estadoServico);
        public Task<bool> DeleteEstadoServico(int id);
        public Task<EstadoServico> GetEstadoServico(int id);
        public Task<IEnumerable<EstadoServico>> GetAllEstadosServico();
    }
}
