using BuildingBug.Application.Configurations;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BuildingBug.Infrastructure.Gateways
{
    public class ClienteGateway : IClienteGateway
    {
        private readonly SQLSettings _sqlSettings;

        public ClienteGateway(IApplicationSettings applicationSettings)
        {
            _sqlSettings = applicationSettings.SQLSettings;
        }

        public async Task<Cliente> GetCliente(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Cliente WHERE id = {id}";

                var result = connection.Query<Cliente>(query).FirstOrDefault();

                if (result != null)
                    return result;
                else
                    throw new InvalidOperationException($"Cliente com o id {id} não encontrado.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Cliente";

                var result = connection.Query<Cliente>(query).ToList();

                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<Cliente> GetClienteLogin(string email)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Cliente WHERE Email = '{email}' AND Cliente.Inactive IS NULL";

                var result = connection.Query<Cliente>(query).FirstOrDefault();

                if (result != null)
                {
                    return result;
                }
                else
                {

                    throw new InvalidOperationException($"Nenhum cliente encontrado com o email: {email}");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> CreateCliente(Cliente cliente)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();


                var query = @$"EXEC ClienteInsert '{cliente.Nome}', '{cliente.Apelido}', '{cliente.Email}', '{cliente.Senha}','{cliente.Contacto}'";


                var result = connection.Query<int>(query).FirstOrDefault();

                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();



                var query = @$"EXEC ClienteUpdate '{cliente.Id}', '{cliente.Nome}', '{cliente.Apelido}', '{cliente.Contacto}' ";

                var result = connection.Query<int>(query).FirstOrDefault();

                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteCliente(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC ClienteDelete {id}";

                var result = connection.Query<int>(query).FirstOrDefault();

                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}