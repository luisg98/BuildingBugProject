using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class ServicoService : IServicoService
    {
        private readonly ILogger<ServicoService> _logger;
        private readonly IServicoGateway _servicoGateway;

        public ServicoService(ILogger<ServicoService> logger, IServicoGateway servicoGateway)
        {
            _logger = logger;
            _servicoGateway = servicoGateway;
        }

        public async Task<Servico> GetServicoById(int id)
        {
            try
            {
                var servico = await _servicoGateway.GetServicoById(id);
                return servico;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter serviço");
                throw;
            }
        }

        public async Task<IEnumerable<Servico>> GetAllServicos()
        {
            try
            {
                var servico = await _servicoGateway.GetAllServicos();
                return servico;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter todos os serviços");
                throw;
            }
        }

        public async Task<IEnumerable<ServicoDTO>> GetAllServicosDeProfissional(int id)
        {
            try
            {
                var servico = await _servicoGateway.GetAllServicosDeProfissional(id);
                return servico;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter todos os serviços");
                throw;
            }
        }

        public async Task<IEnumerable<ServicoDTO>> GetAllServicosDeCliente(int id)
        {
            try
            {
                var servico = await _servicoGateway.GetAllServicosDeCliente(id);
                return servico;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter todos os serviços");
                throw;
            }
        }

        public async Task<IEnumerable<ServicoDTO>> GetAllServicosParaProfissional()
        {
            try
            {
                var servico = await _servicoGateway.GetAllServicosParaProfissional();
                return servico;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter todos os serviços");
                throw;
            }
        }

        public Task<Servico> GetServicoByEmail(string email)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> CreateServico(Servico servico)
        {
            try
            {
                if (string.IsNullOrEmpty(servico.Morada))
                {
                    throw new ArgumentNullException("Morada é um campo obrigatório");
                }

                return await _servicoGateway.CreateServico(servico);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar criar serviço");
                throw;
            }
        }

        public async Task<bool> UpdateServico(Servico servico)
        {
            try
            {

                return await _servicoGateway.UpdateServico(servico);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar atualizar serviço");
                throw;
            }
        }

        public async Task<bool> DeleteServico(int id)
        {
            try
            {
                return await _servicoGateway.DeleteServico(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar remover serviço");
                throw;
            }
        }

        public async Task<bool> AceitarServico(int profissionalId, int id)
        {
            try
            {
                return await _servicoGateway.AceitarServico(profissionalId, id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar remover serviço");
                throw;
            }
        }
    }
}
