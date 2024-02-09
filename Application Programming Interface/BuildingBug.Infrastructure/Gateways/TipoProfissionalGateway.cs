using BuildingBug.Application.Configurations;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BuildingBug.Infrastructure.Gateways
{
    public class TipoProfissionalGateway : ITipoProfissionalGateway
    {
        private readonly SQLSettings _sqlSettings;

        public TipoProfissionalGateway(IApplicationSettings applicationSettings)
        {
            _sqlSettings = applicationSettings.SQLSettings;
        }

        public async Task<bool> CreateTipoProfissional(TipoProfissional tipoProfissional)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC Tipo_ProfissionalInsert '{tipoProfissional.ProfissionalId}', '{tipoProfissional.TipoId}'";

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

        public async Task<bool> UpdateTipoProfissional(TipoProfissional tipoProfissional)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC Tipo_ProfissionalUpdate '{tipoProfissional.ProfissionalId}', '{tipoProfissional.TipoId}'";

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

        public async Task<bool> DeleteTipoProfissional(int tipoId, int profissionalId)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $@"EXEC Tipo_ProfissionalDelete '{tipoId}', '{profissionalId}' ";

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

        public async Task<TipoProfissional> GetTipoProfissional(int tipoId, int profissionalId)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Tipo_Profissional WHERE id = {tipoId} AND id = {profissionalId} ";

                var result = connection.Query<TipoProfissional>(query).FirstOrDefault();

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

        public async Task<IEnumerable<TipoProfissional>> GetAllTiposProfissional()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Tipo_Profissional";

                var result = connection.Query<TipoProfissional>(query).ToList();

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
