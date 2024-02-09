using BuildingBug.API.Data.Contracts.Tipos;
using BuildingBug.API.Extensions.Tipos;
using BuildingBug.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingBug.API.Controllers
{
    [ApiVersion("1.0")]
    public class TipoController : ApiBaseController
    {
        private readonly ILogger<TipoController> _logger;
        private readonly ITipoService _tipoService;

        public TipoController(ILogger<TipoController> logger, ITipoService tipoService)
        {
            _logger = logger;
            _tipoService = tipoService;
        }

        /// <summary>
        /// Criar Tipo
        /// </summary>
        [HttpPost]
        [Route("new")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateTipo([FromBody] CreateTipoRequestContract body)
        {
            try
            {
                var tipo = body.ConvertFromBody();
                var response = await _tipoService.CreateTipo(tipo);

                if (!response)
                    throw new Exception("Erro ao tentar criar um tipo");

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Atualizar Tipo
        /// </summary>
        [HttpPut]
        [Route("update")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateTipo([FromBody] UpdateTipoRequestContract body)
        {
            try
            {
                var tipo = body.ConvertFromBody();
                var response = await _tipoService.UpdateTipo(tipo);

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
        /// Eliminar Tipo
        /// </summary>
        [HttpDelete]
        [Route("delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteTipo([FromRoute(Name = "id")] int id)
        {
            try
            {
                var response = await _tipoService.DeleteTipo(id);

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
        /// Obter Tipo
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetTipo([FromRoute(Name = "id")] int id)
        {
            try
            {


                var tipo = await _tipoService.GetTipo(id);

                if (tipo == null)
                    throw new Exception("Tipo não encontrado");

                return Ok(tipo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Obter todos os Tipos
        /// </summary>
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetAllTipos()
        {
            try
            {
                var tipos = await _tipoService.GetAllTipos();

                if (tipos == null)
                    throw new Exception("Erro ao tentar obter todos os tipos");

                return Ok(tipos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obter todos os tipos de uma determinada categoria
        /// </summary>
        [HttpGet("categoria/{categoria}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetAllTiposPorCategoria(string categoria)
        {
            try
            {
                var tipos = await _tipoService.GetAllTiposPorCategoria(categoria);

                if (tipos == null)
                    throw new Exception("Erro ao tentar obter todos os tipos por categoria");

                return Ok(tipos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
