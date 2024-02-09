using BuildingBug.Application.Configurations;
using BuildingBug.Domain.Model;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Globalization;

namespace BuildingBug.Infrastructure.Gateways
{
    public class ServicoGateway : IServicoGateway
    {
        private readonly SQLSettings _sqlSettings;

        public ServicoGateway(IApplicationSettings applicationSettings)
        {
            _sqlSettings = applicationSettings.SQLSettings;
        }

        public async Task<Servico> GetServicoById(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Serviço WHERE id = {id}";

                var result = connection.Query<Servico>(query).FirstOrDefault();

                if (result != null)
                    return result;
                else
                    return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Servico>> GetAllServicos()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = $"SELECT * FROM Serviço";

                var result = connection.Query<Servico>(query).ToList();

                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<IEnumerable<ServicoDTO>> GetAllServicosDeProfissional(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @"
                                SELECT 
                                    s.Id,
                                    s.Morada,
                                    s.DataInicio,
                                    s.DataFim,
                                    s.Custo,
                                    c.Nome + ' ' + c.Apelido AS NomeCliente,
                                    es.Descricao AS EstadoServico,
                                    s.CodigoPostalCP,
                                    p.Nome + ' ' + p.Apelido AS NomeProfissional,
                                    t.Descricao AS Tipo
                                FROM 
                                    Serviço s
                                    INNER JOIN Cliente c ON s.ClienteId = c.Id
                                    INNER JOIN EstadoServiço es ON s.EstadoServicoId = es.Id
                                    INNER JOIN Profissional p ON s.ProfissionalId = p.Id
                                    INNER JOIN Tipo t ON s.TipoId = t.Id
                                WHERE 
                                    s.ProfissionalId = 1 AND s.Inactive IS NULL";

                var result = connection.Query<ServicoDTO>(query).ToList();

                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IEnumerable<ServicoDTO>> GetAllServicosParaProfissional()
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @"
                               SELECT 
                                    s.Id,
                                    s.Morada,
                                    s.DataInicio,
                                    s.DataFim,
                                    s.Custo,
                                    c.Nome + ' ' + c.Apelido AS NomeCliente,
                                    es.Descricao AS EstadoServico,
                                    s.CodigoPostalCP,
                                    CASE 
                                        WHEN s.ProfissionalId IS NOT NULL 
                                        THEN p.Nome + ' ' + p.Apelido 
                                        ELSE NULL 
                                    END AS NomeProfissional,
                                    t.Descricao AS Tipo,
                                    s.ProfissionalId,
                                    s.Inactive
                                FROM 
                                    Serviço s
                                    INNER JOIN Cliente c ON s.ClienteId = c.Id
                                    INNER JOIN EstadoServiço es ON s.EstadoServicoId = es.Id
                                    LEFT JOIN Profissional p ON s.ProfissionalId = p.Id
                                    INNER JOIN Tipo t ON s.TipoId = t.Id
                                WHERE 
                                    s.Inactive IS NULL AND s.ProfissionalId IS NULL
                ";

                var result = connection.Query<ServicoDTO>(query).ToList();

                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ServicoDTO>> GetAllServicosDeCliente(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @"
                                SELECT 
                                    s.Id,
                                    s.Morada,
                                    s.DataInicio,
                                    s.DataFim,
                                    s.Custo,
                                    c.Nome + ' ' + c.Apelido AS NomeCliente,
                                    es.Descricao AS EstadoServico,
                                    s.CodigoPostalCP,
                                    p.Nome + ' ' + p.Apelido AS NomeProfissional,
                                    t.Descricao AS Tipo
                                FROM 
                                    Serviço s
                                    INNER JOIN Cliente c ON s.ClienteId = c.Id
                                    INNER JOIN EstadoServiço es ON s.EstadoServicoId = es.Id
                                    INNER JOIN Profissional p ON s.ProfissionalId = p.Id
                                    INNER JOIN Tipo t ON s.TipoId = t.Id
                                WHERE 
                                    s.CLienteId = @ClienteId";

                var result = await connection.QueryAsync<ServicoDTO>(query, new { ClienteId = id });


                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> CreateServico(Servico servico)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();


                var query = @$"EXEC ServiçoInsert '{servico.Morada}', '{servico.ClienteId}', '{servico.CodigoPostalCP}', '{servico.Fator}', '{servico.TipoId}'";


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


        public async Task<bool> UpdateServico(Servico servico)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();


                var query = @$"EXEC ServiçoUpdate '{servico.Id}','{servico.Morada}','{servico.DataInicio:yyyy-MM-dd HH:mm:ss.fff}','{servico.DataFim:yyyy-MM-dd HH:mm:ss.fff}','{servico.Avaliacao}', '{servico.Custo.ToString("0.00", CultureInfo.InvariantCulture)}', '{servico.ClienteId}', '{servico.EstadoServicoId}', '{servico.CodigoPostalCP}', '{servico.ProfissionalId}', '{servico.TipoId}'";


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


        public async Task<bool> DeleteServico(int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC ServiçoDelete {id}";

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

        public async Task<bool> AceitarServico(int profissionalId, int id)
        {
            try
            {
                await using var connection = new SqlConnection(_sqlSettings.ConnectionString);
                await connection.OpenAsync();

                var query = @$"EXEC ServiçoAceitar {id} , {profissionalId}";

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