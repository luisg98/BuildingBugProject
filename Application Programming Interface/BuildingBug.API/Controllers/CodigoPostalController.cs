using BuildingBug.API.Data.Contracts.CodigosPostais;
using BuildingBug.API.Extensions.CodigosPostais;
using BuildingBug.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingBug.API.Controllers
{
    [ApiVersion("1.0")]
    public class CodigoPostalController : ApiBaseController
    {
        private readonly ILogger<CodigoPostalController> _logger;
        private readonly ICodigoPostalService _codigoPostalService;

        public CodigoPostalController(ILogger<CodigoPostalController> logger, ICodigoPostalService codigoPostalService)
        {
            _logger = logger;
            _codigoPostalService = codigoPostalService;
        }


        /// <summary>
        /// Criar um código postal
        /// </summary>
        [HttpPost]
        [Route("new")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateCodigoPostal([FromBody] CreateCodigoPostalRequestContract body)
        {
            try
            {
                var codigoPostal = body.ConvertFromBody();
                var response = await _codigoPostalService.CreateCodigoPostal(codigoPostal);

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
        /// Atualizar um código postal
        /// </summary>
        [HttpPut]
        [Route("update")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCodigoPostal([FromBody] UpdateCodigoPostalRequestContract body)
        {
            try
            {
                var codigoPostal = body.ConvertFromBody();
                var response = await _codigoPostalService.UpdateCodigoPostal(codigoPostal);

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
        /// Eliminar um código postal
        /// </summary>
        [HttpDelete]
        [Route("delete/{cp}")]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> DeleteCodigoPostal([FromRoute(Name = "cp")] int cp)
        {
            try
            {
                var response = await _codigoPostalService.DeleteCodigoPostal(cp);

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

        [HttpGet]
        [Route("{cp}")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetCodigoPostal([FromRoute(Name = "cp")] int cp)
        {
            try
            {
                var codigoPostal = await _codigoPostalService.GetCodigoPostal(cp);

                if (codigoPostal == null)
                    throw new Exception("CodigoPostal não pode ser nula (CodigoPostal não encontrada).");

                return Ok(codigoPostal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Cliente, Profissional")]
        public async Task<IActionResult> GetAllCodigosPostais()
        {
            try
            {
                var codigosPostais = await _codigoPostalService.GetAllCodigosPostais();

                if (codigosPostais == null)
                    throw new Exception("Erro a tentar obter todas as CodigosPostais.");

                var listOfCodigosPostais = new List<GetAllCodigosPostaisResponseContract>();

                foreach (var codigoPostal in codigosPostais)
                {
                    listOfCodigosPostais.Add(new GetAllCodigosPostaisResponseContract()
                    {
                        CP = codigoPostal.CP,
                        Distrito = codigoPostal.Distrito,
                    });
                }

                return Ok(listOfCodigosPostais);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
