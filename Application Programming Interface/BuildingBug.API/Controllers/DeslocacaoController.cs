using BuildingBug.API.Data.Contracts.Deslocacoes;
using BuildingBug.API.Extensions.CodigosPostais;
using BuildingBug.API.Extensions.Deslocacoes;
using BuildingBug.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingBug.API.Controllers
{
    [ApiVersion("1.0")]
    public class DeslocacaoController : ApiBaseController
    {
        private readonly ILogger<DeslocacaoController> _logger;
        private readonly IDeslocacaoService _deslocacaoService;

        public DeslocacaoController(ILogger<DeslocacaoController> logger, IDeslocacaoService deslocacaoService)
        {
            _logger = logger;
            _deslocacaoService = deslocacaoService;
        }

        /// <summary>
        /// Marcar uma Deslocação
        /// </summary>
        [HttpPost]
        [Route("new")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> CreateDeslocacao([FromBody] CreateDeslocacaoRequestContract body)
        {
            try
            {
                var deslocacao = body.ConvertFromBody();
                var response = await _deslocacaoService.CreateDeslocacao(deslocacao);

                if (!response)
                    throw new Exception("Erro ao tentar criar uma deslocação");

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Atualizar uma deslocação
        /// </summary>
        [HttpPut]
        [Route("update")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> UpdateDeslocacao([FromBody] UpdateDeslocacaoRequestContract body)
        {
            try
            {
                var deslocacao = body.ConvertFromBody();
                var response = await _deslocacaoService.UpdateDeslocacao(deslocacao);

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
        /// Eliminar uma deslocação
        /// </summary>
        [HttpDelete]
        [Route("delete/{id}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> DeleteDeslocacao([FromRoute(Name = "id")] int id)
        {
            try
            {
                var response = await _deslocacaoService.DeleteDeslocacao(id);

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
        /// Obter uma deslocação
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetDeslocacao([FromRoute(Name = "id")] int id)
        {
            try
            {

                var deslocacao = await _deslocacaoService.GetDeslocacao(id);

                if (deslocacao == null)
                    throw new Exception("Deslocação não pode ser nula");

                return Ok(deslocacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obter todas as deslocações
        /// </summary>
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetAllDeslocacoes()
        {
            try
            {
                var deslocacoes = await _deslocacaoService.GetAllDeslocacoes();

                if (deslocacoes == null)
                    throw new Exception("Erro a tentar obter todas as deslocações");

                return Ok(deslocacoes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
