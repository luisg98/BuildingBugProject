using BuildingBug.API.Data.Contracts.EstadoServico;
using BuildingBug.API.Extensions.EstadosServico;
using BuildingBug.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingBug.API.Controllers
{
    [ApiVersion("1.0")]
    public class EstadoServicoController : ApiBaseController
    {
        private readonly ILogger<EstadoServicoController> _logger;
        private readonly IEstadoServicoService _estadoServicoService;

        public EstadoServicoController(ILogger<EstadoServicoController> logger, IEstadoServicoService estadoServicoService)
        {
            _logger = logger;
            _estadoServicoService = estadoServicoService;
        }

        /// <summary>
        /// Criar um estado de serviço
        /// </summary>
        [HttpPost]
        [Route("new")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateEstadoServico([FromBody] CreateEstadoServicoRequestContract body)
        {
            try
            {
                var estadoServico = body.ConvertFromBody();
                var response = await _estadoServicoService.CreateEstadoServico(estadoServico);

                if (!response)
                    throw new Exception("Erro ao tentar criar um estado de serviço");

                return Ok(estadoServico.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Atualizar um estado de serviço
        /// </summary>
        [HttpPut]
        [Route("update")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateEstadoServico([FromBody] UpdateEstadoServicoRequestContract body)
        {
            try
            {
                var estadoServico = body.ConvertFromBody();
                var response = await _estadoServicoService.UpdateEstadoServico(estadoServico);

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
        /// Eliminar um estado de serviço
        /// </summary>
        [HttpDelete]
        [Route("delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteEstadoServico([FromRoute(Name = "id")] int id)
        {
            try
            {
                var response = await _estadoServicoService.DeleteEstadoServico(id);

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
        /// Obter o estado de serviço
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetEstadoServico([FromRoute(Name = "id")] int id)
        {
            try
            {

                var estadoServico = await _estadoServicoService.GetEstadoServico(id);

                if (estadoServico == null)
                    throw new Exception("Estado de serviço não pode ser nulo");

                return Ok(estadoServico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obter todos os estados de serviço
        /// </summary>
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetAllEstadosServicos()
        {
            try
            {
                var estadosServico = await _estadoServicoService.GetAllEstadosServico();

                if (estadosServico == null)
                    throw new Exception("Erro ao obter todos os estados de serviço");

                return Ok(estadosServico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}