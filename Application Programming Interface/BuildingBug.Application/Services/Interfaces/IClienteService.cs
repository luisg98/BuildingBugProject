using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface IClienteService
    {
        public Task<Cliente> GetClienteByEmail(string email);

        public Task<Cliente> GetClienteLogin(string email, string password);

        public Task<bool> CreateCliente(Cliente cliente);

        public Task<bool> UpdateCliente(Cliente cliente);

        public Task<bool> DeleteCliente(int id);

        public Task<Cliente> GetCliente(int id);

        public Task<IEnumerable<Cliente>> GetAllClientes();
    }
}