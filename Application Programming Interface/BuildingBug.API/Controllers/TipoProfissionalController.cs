using BuildingBug.API.Data.Contracts.TiposProfissional;
using BuildingBug.API.Extensions.TiposProfissional;
using BuildingBug.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingBug.API.Controllers
{
    [ApiVersion("1.0")]
    public class TipoProfissionalController : ApiBaseController
    {
        private readonly ILogger<TipoProfissionalController> _logger;
        private readonly ITipoProfissionalService _tipoProfissionalService;

        public TipoProfissionalController(ILogger<TipoProfissionalController> logger, ITipoProfissionalService tipoProfissionalService)
        {
            _logger = logger;
            _tipoProfissionalService = tipoProfissionalService;
        }

        /// <summary>
        /// Criar tipo de profissional
        /// </summary>
        [HttpPost]
        [Route("new")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> CreateTipoProfissional([FromBody] CreateTipoProfissionalRequestContract body)
        {
            try
            {
                var tipoProfissional = body.ConvertFromBody();
                var response = await _tipoProfissionalService.CreateTipoProfissional(tipoProfissional);

                if (!response)
                    throw new Exception("Erro a tentar criar tipo de profissional");

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Eliminar tipo de profissional
        /// </summary>
        [HttpDelete]
        [Route("delete")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> DeleteTipoProfissional(int tipoId, int profissionalId)
        {
            try
            {
                var response = await _tipoProfissionalService.DeleteTipoProfissional(tipoId, profissionalId);

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
        /// Obter tipo de profissional
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Profissional")]
        [Route("{tipoId}/{profissionalId}")]
        public async Task<IActionResult> GetTipoProfissional([FromRoute(Name = "tipoId")] int tipoId, [FromRoute(Name = "profissionalId")] int profissionalId)
        {
            try
            {


                var tipoProfissional = await _tipoProfissionalService.GetTipoProfissional(tipoId, profissionalId);

                if (tipoProfissional == null)
                    throw new Exception("Tipo de profissional não pode ser nulo (tipo de profissional não encontrado)");

                return Ok(tipoProfissional);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obter todos os tipos de profissional
        /// </summary>
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> GetAllTiposProfissional()
        {
            try
            {
                var tiposProfissional = await _tipoProfissionalService.GetAllTiposProfissional();

                if (tiposProfissional == null)
                    throw new Exception("Erro ao obter todos os tipos de profissional");

                return Ok(tiposProfissional);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
