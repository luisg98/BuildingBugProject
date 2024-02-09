using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Microsoft.Extensions.Logging;

namespace BuildingBug.Infrastructure.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ILogger<ClienteService> _logger;
        private readonly IClienteGateway _clienteGateway;
        private readonly IPasswordService _passwordService;

        public ClienteService(ILogger<ClienteService> logger, IClienteGateway clienteGateway, IPasswordService passwordService)
        {
            _logger = logger;
            _clienteGateway = clienteGateway;
            _passwordService = passwordService;
        }

        public async Task<Cliente> GetCliente(int id)
        {
            try
            {
                var cliente = await _clienteGateway.GetCliente(id);
                return cliente;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter cliente");
                throw;
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            try
            {
                var cliente = await _clienteGateway.GetAllClientes();
                return cliente;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar obter todos os clientees");
                throw;
            }
        }

        public Task<Cliente> GetClienteByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> GetClienteLogin(string email, string senha)
        {
            var message = "Erro ao efetuar login";
            try
            {
                var result = await _clienteGateway.GetClienteLogin(email);

                if (result is null || string.IsNullOrEmpty(result.Senha))
                {
                    throw new Exception(message);
                }

                var clienteValid = _passwordService.VerifyHashedPassword(result.Senha, senha);


                if (!clienteValid)
                {
                    throw new Exception(message);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar criar cliente");
                throw;
            }
        }

        public async Task<bool> CreateCliente(Cliente cliente)
        {
            try
            {
                if (string.IsNullOrEmpty(cliente.Senha))
                {
                    throw new ArgumentNullException("Senha é um campo obrigatório");
                }

                var hashPassword = _passwordService.HashPassword(cliente.Senha);

                cliente.Senha = hashPassword;

                return await _clienteGateway.CreateCliente(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar criar cliente");
                throw;
            }
        }

        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            try
            {
                if (!string.IsNullOrEmpty(cliente.Senha))
                {
                    var hashPassword = _passwordService.HashPassword(cliente.Senha);
                    cliente.Senha = hashPassword;
                }

                return await _clienteGateway.UpdateCliente(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar atualizador cliente");
                throw;
            }
        }

        public async Task<bool> DeleteCliente(int id)
        {
            try
            {
                return await _clienteGateway.DeleteCliente(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao tentar remover cliente");
                throw;
            }
        }
    }
}
