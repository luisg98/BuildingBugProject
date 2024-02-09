using BuildingBug.API.Data.Contracts.Servicos;
using BuildingBug.API.Extensions;
using BuildingBug.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BuildingBug.Domain.Model;
using System.Linq;

namespace BuildingBug.API.Controllers
{
    [ApiVersion("1.0")]
    public class ServicoController : ApiBaseController
    {
        private readonly ILogger<ServicoController> _logger;
        private readonly IServicoService _servicoService;
        private readonly IConfiguration _configuration;

        public ServicoController(ILogger<ServicoController> logger, IServicoService servicoService, IConfiguration configuration)
        {
            _logger = logger;
            _servicoService = servicoService;
            _configuration = configuration;
        }


        /// <summary>
        /// Pedir serviço
        /// </summary>
        [Authorize(Roles = "Cliente, Profissional")]
        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> CreateServico([FromBody] CreateServicoRequestContract body)
        {
            try
            {
                var servico = body.ConvertFromBody();
                var response = await _servicoService.CreateServico(servico);

                if (!response)
                {
                    return BadRequest();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Atualizar serviço
        /// </summary>
        [HttpPut]
        [Route("update")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> UpdateServico([FromBody] UpdateServicoRequestContract body)
        {
            try
            {
                var servico = body.ConvertFromBody();
                var response = await _servicoService.UpdateServico(servico);

                if (!response)
                {
                    return BadRequest();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Eliminar serviço
        /// </summary>
        [HttpDelete]
        [Route("delete/{id}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> DeleteServico([FromRoute(Name = "id")] int id)
        {
            try
            {
                var response = await _servicoService.DeleteServico(id);

                if (!response)
                {
                    return BadRequest();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obter serviço
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetServico([FromRoute(Name = "id")] int id)
        {
            try
            {

                var servico = await _servicoService.GetServicoById(id);

                if (servico == null)
                    throw new Exception("Serviço não pode ser nulo (serviço não encontrado).");

                return Ok(new GetServicoResponseContract()
                {
                    Id = servico.Id,
                    Morada = servico.Morada,
                    DataInicio = servico.DataInicio,
                    Custo = servico.Custo,
                    Inactive = servico.Inactive,
                    ClienteId = servico.ClienteId,
                    EstadoServicoId = servico.EstadoServicoId,
                    CodigoPostalCP = servico.CodigoPostalCP,
                    ProfissionalId = servico.ProfissionalId,
                    TipoId = servico.TipoId

                });



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obter todos os serviços
        /// </summary>
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetAllServicos()
        {
            try
            {
                var servico = await _servicoService.GetAllServicos();

                if (servico == null)
                    throw new Exception("Erro a tentar obter os serviços");

                return Ok(servico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("all/{profissionalId}")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> GetAllServicosDeProfissional(int profissionalId)
        {
            try
            {
                var servico = await _servicoService.GetAllServicosDeProfissional(profissionalId);

                if (servico == null)
                    throw new Exception("Erro a tentar obter os serviços");

                return Ok(servico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("all/Cliente/{clienteId}")]
        [Authorize(Roles = "Cliente")]
        public async Task<IActionResult> GetAllServicosDeCliente(int clienteId)
        {
            try
            {
                var servico = await _servicoService.GetAllServicosDeCliente(clienteId);

                if (servico == null)
                    throw new Exception("Erro a tentar obter os serviços");

                return Ok(servico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("all/disponivel")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> GetAllServicosParaProfissional()
        {
            try
            {
                var servicos = await _servicoService.GetAllServicosParaProfissional();

                if (servicos == null || !servicos.Any())
                    throw new Exception("Erro a tentar obter os serviços");

                var servicosResponse = servicos.Select(servico => new GetAllServicosDetalhesResponseContract()
                {
                    Id = servico.Id,
                    Morada = servico.Morada,
                    DataInicio = servico.DataInicio,
                    DataFim = servico.DataFim,
                    Custo = servico.Custo,
                    NomeCliente = servico.NomeCliente,
                    EstadoServico = servico.EstadoServico,
                    CodigoPostalCP = servico.CodigoPostalCP,
                    NomeProfissional = servico.NomeProfissional,
                    Tipo = servico.Tipo

                }).ToList();

                return Ok(servicosResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPut]
        [Route("aceitar/{profissionalId}/{id}")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> AceitarServico(int profissionalId, int id)
        {
            try
            {
                var servico = await _servicoService.AceitarServico(profissionalId, id);

                if (servico == null)
                    throw new Exception("Erro a tentar aceitar o serviço");

                return Ok(servico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }






    }
}