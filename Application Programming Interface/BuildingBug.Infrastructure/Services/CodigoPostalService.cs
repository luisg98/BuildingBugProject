using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class CodigoPostalService : ICodigoPostalService
    {
        private readonly ILogger<CodigoPostalService> _logger;
        private readonly ICodigoPostalGateway _CodigoPostalGateway;

        public CodigoPostalService(ILogger<CodigoPostalService> logger, ICodigoPostalGateway CodigoPostalGateway)
        {
            _logger = logger;
            _CodigoPostalGateway = CodigoPostalGateway;
        }

        public async Task<bool> CreateCodigoPostal(CodigoPostal CodigoPostal)
        {
            try
            {
                return await _CodigoPostalGateway.CreateCodigoPostal(CodigoPostal);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar criar o código postal");
                throw;
            }
        }

        public async Task<bool> UpdateCodigoPostal(CodigoPostal CodigoPostal)
        {
            try
            {
                return await _CodigoPostalGateway.UpdateCodigoPostal(CodigoPostal);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar atualizar o código postal");
                throw;
            }
        }

        public async Task<bool> DeleteCodigoPostal(int id)
        {
            try
            {
                return await _CodigoPostalGateway.DeleteCodigoPostal(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar remover o código postal");
                throw;
            }
        }

        public async Task<CodigoPostal> GetCodigoPostal(int id)
        {
            try
            {
                return await _CodigoPostalGateway.GetCodigoPostal(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter o código postal");
                throw;
            }
        }

        public async Task<IEnumerable<CodigoPostal>> GetAllCodigosPostais()
        {
            try
            {
                var codigoPostalCP = await _CodigoPostalGateway.GetAllCodigosPostais();
                return codigoPostalCP;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter todas os códigos postais");
                throw;
            }
        }
    }
}