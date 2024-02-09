using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class TipoService : ITipoService
    {
        private readonly ILogger<TipoService> _logger;
        private readonly ITipoGateway _tipoGateway;

        public TipoService(ILogger<TipoService> logger, ITipoGateway tipoGateway)
        {
            _logger = logger;
            _tipoGateway = tipoGateway;
        }

        public async Task<bool> CreateTipo(Tipo tipo)
        {
            try
            {
                return await _tipoGateway.CreateTipo(tipo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> UpdateTipo(Tipo tipo)
        {
            try
            {
                return await _tipoGateway.UpdateTipo(tipo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar atualizar tipo");
                throw;
            }
        }

        public async Task<bool> DeleteTipo(int id)
        {
            try
            {
                return await _tipoGateway.DeleteTipo(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar remover tipo");
                throw;
            }
        }

        public async Task<Tipo> GetTipo(int id)
        {
            try
            {
                var tipo = await _tipoGateway.GetTipo(id);
                return tipo;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter tipo");
                throw;
            }
        }

        public async Task<IEnumerable<Tipo>> GetAllTipos()
        {
            try
            {
                var tipos = await _tipoGateway.GetAllTipos();
                return tipos;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter lista do tipo");
                throw;
            }
        }

        public async Task<IEnumerable<Tipo>> GetAllTiposPorCategoria(string categoria)
        {
            try
            {
                var tipos = await _tipoGateway.GetAllTiposPorCategoria(categoria);
                return tipos;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter lista do tipo");
                throw;
            }
        }
    }
}
