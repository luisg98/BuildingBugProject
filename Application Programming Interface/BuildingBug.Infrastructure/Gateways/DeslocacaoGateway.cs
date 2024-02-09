using BuildingBug.Application.Configurations;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BuildingBug.Infrastructure.Gateways
{
    public class DeslocacaoGateway : IDeslocacaoGateway
    {
        private readonly SQLSettings _sqlSettings;

        public DeslocacaoGateway(IApplicationSettings applicationSettings)
        {
            _sqlSettings = applicationSettings.SQLSettings;
        }

        public async Task<bool> CreateDeslocacao(Deslocacao Deslocacao)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC DeslocaçãoInsert '{Deslocacao.Data:yyyy-MM-dd HH:mm:ss.fff}','{Deslocacao.ServicoId}','{Deslocacao.Detalhes}'";

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

        public async Task<bool> UpdateDeslocacao(Deslocacao Deslocacao)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC DeslocaçãoUpdate {Deslocacao.Id}, '{Deslocacao.Data:yyyy-MM-dd HH:mm:ss.fff}', {Deslocacao.ServicoId},'{Deslocacao.Detalhes}'";

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

        public async Task<bool> DeleteDeslocacao(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $@"EXEC DeslocaçãoDelete {id}";

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

        public async Task<Deslocacao> GetDeslocacao(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Deslocação WHERE id = {id}";

                var result = connection.Query<Deslocacao>(query).FirstOrDefault();

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

        public async Task<IEnumerable<Deslocacao>> GetAllDeslocacoes()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Deslocação";

                var result = connection.Query<Deslocacao>(query).ToList();

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
