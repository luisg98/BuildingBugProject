using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class TipoProfissionalService : ITipoProfissionalService
    {
        private readonly ILogger<TipoProfissionalService> _logger;
        private readonly ITipoProfissionalGateway _tipoProfissionalGateway;

        public TipoProfissionalService(ILogger<TipoProfissionalService> logger, ITipoProfissionalGateway TipoProfissionalGateway)
        {
            _logger = logger;
            _tipoProfissionalGateway = TipoProfissionalGateway;
        }

        public async Task<bool> CreateTipoProfissional(TipoProfissional TipoProfissional)
        {
            try
            {
                return await _tipoProfissionalGateway.CreateTipoProfissional(TipoProfissional);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar criar tipo de profissional");
                throw;
            }
        }

        public async Task<bool> UpdateTipoProfissional(TipoProfissional TipoProfissional)
        {
            try
            {
                return await _tipoProfissionalGateway.UpdateTipoProfissional(TipoProfissional);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar atualizar tipo de profissional");
                throw;
            }
        }

        public async Task<bool> DeleteTipoProfissional(int tipoId, int profissionalId)
        {
            try
            {
                return await _tipoProfissionalGateway.DeleteTipoProfissional(tipoId, profissionalId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar remover tipo de profissional");
                throw;
            }
        }

        public async Task<TipoProfissional> GetTipoProfissional(int profissionalId, int tipoId)
        {
            try
            {
                return await _tipoProfissionalGateway.GetTipoProfissional(profissionalId, tipoId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter tipo de profissional");
                throw;
            }
        }

        public async Task<IEnumerable<TipoProfissional>> GetAllTiposProfissional()
        {
            try
            {
                var tiposProfissional = await _tipoProfissionalGateway.GetAllTiposProfissional();
                return tiposProfissional;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter lista do tipo de profissional");
                throw;
            }
        }
    }
}