using BuildingBug.Domain.Model;

namespace BuildingBug.Infrastructure.Gateways.Interfaces
{
    public interface IClienteGateway
    {

        public Task<Cliente> GetClienteLogin(string email);

        public Task<bool> CreateCliente(Cliente cliente);

        public Task<bool> UpdateCliente(Cliente cliente);

        public Task<bool> DeleteCliente(int id);

        public Task<Cliente> GetCliente(int id);

        public Task<IEnumerable<Cliente>> GetAllClientes();
    }
}
