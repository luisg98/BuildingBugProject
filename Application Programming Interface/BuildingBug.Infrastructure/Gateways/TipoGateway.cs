using BuildingBug.Application.Configurations;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BuildingBug.Infrastructure.Gateways
{
    public class TipoGateway : ITipoGateway
    {
        private readonly SQLSettings _sqlSettings;

        public TipoGateway(IApplicationSettings applicationSettings)
        {
            _sqlSettings = applicationSettings.SQLSettings;
        }

        public async Task<bool> CreateTipo(Tipo tipo)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC TipoInsert '{tipo.Descricao}', '{tipo.Preco}', '{tipo.Fator}', '{tipo.Categoria}'";

                var result = connection.Query<int>(query).FirstOrDefault();

                if (result != 0)
                    return true;
                else
                    return false;
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
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC TipoUpdate {tipo.Id}, '{tipo.Descricao}', '{tipo.Preco}', '{tipo.Fator}', '{tipo.Categoria}'";

                var result = connection.Query<int>(query).FirstOrDefault();

                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> DeleteTipo(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $@"EXEC TipoDelete {id}";

                var result = connection.Query<int>(query).FirstOrDefault();

                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Tipo> GetTipo(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Tipo WHERE id = {id}";

                var result = connection.Query<Tipo>(query).FirstOrDefault();

                if (result != null)
                    return result;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Tipo>> GetAllTipos()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Tipo";

                var result = connection.Query<Tipo>(query).ToList();

                if (result != null)
                    return result;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<IEnumerable<Tipo>> GetAllTiposPorCategoria(string categoria)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Tipo WHERE Categoria = '{categoria}'";

                var result = connection.Query<Tipo>(query).ToList();

                if (result != null)
                    return result;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
