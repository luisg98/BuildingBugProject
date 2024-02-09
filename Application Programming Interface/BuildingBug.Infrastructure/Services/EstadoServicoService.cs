using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class EstadoServicoService : IEstadoServicoService
    {
        private readonly ILogger<EstadoServicoService> _logger;
        private readonly IEstadoServicoGateway _estadoServicoGateway;

        public EstadoServicoService(ILogger<EstadoServicoService> logger, IEstadoServicoGateway estadoServicoGateway)
        {
            _logger = logger;
            _estadoServicoGateway = estadoServicoGateway;
        }

        public async Task<bool> CreateEstadoServico(EstadoServico estadoServico)
        {
            try
            {
                return await _estadoServicoGateway.CreateEstadoServico(estadoServico);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> UpdateEstadoServico(EstadoServico estadoServico)
        {
            try
            {
                return await _estadoServicoGateway.UpdateEstadoServico(estadoServico);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar atualizar o estado de serviço com o id [{id}]", estadoServico.Id);
                throw;
            }
        }

        public async Task<bool> DeleteEstadoServico(int id)
        {
            try
            {
                return await _estadoServicoGateway.DeleteEstadoServico(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar remover o estado de serviço com o id [{id}]", id);
                throw;
            }
        }

        public async Task<EstadoServico> GetEstadoServico(int id)
        {
            try
            {
                var estadoServico = await _estadoServicoGateway.GetEstadoServico(id);
                return estadoServico;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter o estado de serviço com o id [{id}]", id);
                throw;
            }
        }

        public async Task<IEnumerable<EstadoServico>> GetAllEstadosServico()
        {
            try
            {
                var estadosServico = await _estadoServicoGateway.GetAllEstadosServico();
                return estadosServico;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter todos os estados de serviço");
                throw;
            }
        }
    }
}
