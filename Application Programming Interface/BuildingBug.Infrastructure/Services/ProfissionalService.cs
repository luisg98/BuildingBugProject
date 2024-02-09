using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class ProfissionalService : IProfissionalService
    {
        private readonly ILogger<ProfissionalService> _logger;
        private readonly IProfissionalGateway _profissionalGateway;
        private readonly IPasswordService _passwordService;

        public ProfissionalService(ILogger<ProfissionalService> logger, IProfissionalGateway profissionalGateway, IPasswordService passwordService)
        {
            _logger = logger;
            _profissionalGateway = profissionalGateway;
            _passwordService = passwordService;
        }

        public async Task<bool> CreateProfissional(Profissional profissional)
        {
            try
            {
                if (string.IsNullOrEmpty(profissional.Senha))
                {
                    throw new ArgumentNullException("Senha é um campo obrigatório");
                }

                var hashPassword = _passwordService.HashPassword(profissional.Senha);

                profissional.Senha = hashPassword;

                return await _profissionalGateway.CreateProfissional(profissional);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar criar profissional");
                throw;
            }
        }

        public async Task<bool> UpdateProfissional(Profissional profissional)
        {
            try
            {
                return await _profissionalGateway.UpdateProfissional(profissional);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar atualizar profissional");
                throw;
            }
        }

        public async Task<bool> DeleteProfissional(int id)
        {
            try
            {
                return await _profissionalGateway.DeleteProfissional(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar remover profissional");
                throw;
            }
        }

        public async Task<Profissional> GetProfissional(int id)
        {
            try
            {
                var profissional = await _profissionalGateway.GetProfissional(id);
                return profissional;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter profissional");
                throw;
            }
        }

        public async Task<Profissional> GetProfissionalLogin(string email, string senha)
        {
            var message = "Erro ao tentar efetuar login";
            try
            {
                var result = await _profissionalGateway.GetProfissionalLogin(email);

                if (result is null || string.IsNullOrEmpty(result.Senha))
                {
                    throw new Exception(message);
                }

                var profissionalValid = _passwordService.VerifyHashedPassword(result.Senha, senha);


                if (!profissionalValid)
                {
                    throw new Exception(message);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar criar profissional");
                throw;
            }
        }

        public async Task<IEnumerable<Profissional>> GetAllProfissionais()
        {
            try
            {
                var profissionais = await _profissionalGateway.GetAllProfissionais();
                return profissionais;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter todos os profissionais");
                throw;
            }
        }



    }
}
