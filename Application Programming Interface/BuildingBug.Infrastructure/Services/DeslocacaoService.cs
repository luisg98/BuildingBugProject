using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class DeslocacaoService : IDeslocacaoService
    {
        private readonly ILogger<DeslocacaoService> _logger;
        private readonly IDeslocacaoGateway _deslocacaoGateway;

        public DeslocacaoService(ILogger<DeslocacaoService> logger, IDeslocacaoGateway DeslocacaoGateway)
        {
            _logger = logger;
            _deslocacaoGateway = DeslocacaoGateway;
        }

        public async Task<bool> CreateDeslocacao(Deslocacao deslocacao)
        {
            try
            {
                return await _deslocacaoGateway.CreateDeslocacao(deslocacao);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> UpdateDeslocacao(Deslocacao deslocacao)
        {
            try
            {
                return await _deslocacaoGateway.UpdateDeslocacao(deslocacao);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar atualizar a deslocação com o id  [{id}]", deslocacao.Id);
                throw;
            }
        }

        public async Task<bool> DeleteDeslocacao(int id)
        {
            try
            {
                return await _deslocacaoGateway.DeleteDeslocacao(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar remover a deslocação com o id [{id}]", id);
                throw;
            }
        }

        public async Task<Deslocacao> GetDeslocacao(int id)
        {
            try
            {
                var deslocacao = await _deslocacaoGateway.GetDeslocacao(id);
                return deslocacao;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter a deslocação com o id [{id}]", id);
                throw;
            }
        }

        public async Task<IEnumerable<Deslocacao>> GetAllDeslocacoes()
        {
            try
            {
                var deslocacoes = await _deslocacaoGateway.GetAllDeslocacoes();
                return deslocacoes;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter todas as deslocações");
                throw;
            }
        }
    }
}
