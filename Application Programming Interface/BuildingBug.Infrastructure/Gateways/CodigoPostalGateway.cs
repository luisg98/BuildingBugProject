using BuildingBug.Application.Configurations;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BuildingBug.Infrastructure.Gateways
{
    public class CodigoPostalGateway : ICodigoPostalGateway
    {
        private readonly SQLSettings _sqlSettings;

        public CodigoPostalGateway(IApplicationSettings applicationSettings)
        {
            _sqlSettings = applicationSettings.SQLSettings;
        }

        public async Task<bool> CreateCodigoPostal(CodigoPostal codigoPostal)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC CódigoPostalInsert '{codigoPostal.CP}','{codigoPostal.Distrito}' ";

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

        public async Task<bool> UpdateCodigoPostal(CodigoPostal codigoPostal)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC CódigoPostalUpdate '{codigoPostal.CP}','{codigoPostal.Distrito}'";

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

        public async Task<bool> DeleteCodigoPostal(int CP)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC CódigoPostalDelete {CP}";

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

        public async Task<CodigoPostal> GetCodigoPostal(int cp)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM CódigoPostal WHERE CP = {cp}";

                var result = connection.Query<CodigoPostal>(query).FirstOrDefault();

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

        public async Task<IEnumerable<CodigoPostal>> GetAllCodigosPostais()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM CódigoPostal";

                var result = connection.Query<CodigoPostal>(query).ToList();

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