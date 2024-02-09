using BuildingBug.Application.Configurations;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using BuildingBug.Infrastructure.Services;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BuildingBug.Infrastructure.Gateways
{

    public class ProfissionalGateway : IProfissionalGateway
    {
        private readonly SQLSettings _sqlSettings;
        private readonly GetDistritoService _getDistritoService; // Serviço para obter o distrito

        public ProfissionalGateway(IApplicationSettings applicationSettings, GetDistritoService getDistritoService)
        {
            _sqlSettings = applicationSettings.SQLSettings;
            _getDistritoService = getDistritoService; // Injeta a dependência do serviço
        }

        public async Task<bool> CreateProfissional(Profissional profissional)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                //profissional.Distrito = await _getDistritoService.GetDistritoAsync(profissional.Latitude, profissional.Longitude);

                var query = @$"EXEC ProfissionalInsert '{profissional.Nome}','{profissional.Apelido}','{profissional.Email}','{profissional.Senha}','{profissional.Contacto}'";

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

        public async Task<bool> UpdateProfissional(Profissional profissional)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                //profissional.Distrito = await _getDistritoService.GetDistritoAsync(profissional.Latitude, profissional.Longitude);

                var query = @$"EXEC ProfissionalUpdate '{profissional.Id}', '{profissional.Nome}','{profissional.Apelido}','{profissional.Contacto}'";

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

        public async Task<bool> DeleteProfissional(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $@"EXEC ProfissionalDelete {id}";

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

        public async Task<Profissional> GetProfissionalLogin(string email)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Profissional WHERE Email = '{email}' AND (Inactive IS NULL OR Inactive = 0)";


                var result = connection.Query<Profissional>(query).FirstOrDefault();

                if (result != null)
                {
                    return result;
                }
                else
                {

                    throw new InvalidOperationException($"Nenhum profissional encontrado com o email: {email}");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Profissional> GetProfissional(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Profissional WHERE id = {id}";

                var result = connection.Query<Profissional>(query).FirstOrDefault();

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

        public async Task<IEnumerable<Profissional>> GetAllProfissionais()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Profissional";

                var result = connection.Query<Profissional>(query).ToList();

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
