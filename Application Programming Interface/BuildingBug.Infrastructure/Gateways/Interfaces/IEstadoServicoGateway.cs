using BuildingBug.Domain.Model;

namespace BuildingBug.Infrastructure.Gateways.Interfaces
{

    public interface IEstadoServicoGateway
    {
        public Task<bool> CreateEstadoServico(EstadoServico estadoServico);
        public Task<bool> UpdateEstadoServico(EstadoServico estadoServico);
        public Task<bool> DeleteEstadoServico(int id);
        public Task<EstadoServico> GetEstadoServico(int id);
        public Task<IEnumerable<EstadoServico>> GetAllEstadosServico();
    }
}

