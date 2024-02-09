using BuildingBug.API.Data.Contracts.Profissionais;
using BuildingBug.API.Extensions.Profissionais;
using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BuildingBug.API.Controllers
{
    [ApiVersion("1.0")]
    public class ProfissionalController : ApiBaseController
    {
        private readonly ILogger<ProfissionalController> _logger;
        private readonly IProfissionalService _profissionalService;
        private readonly IConfiguration _configuration;

        public ProfissionalController(ILogger<ProfissionalController> logger, IProfissionalService profissionalService, IConfiguration configuration)
        {
            _logger = logger;
            _profissionalService = profissionalService;
            _configuration = configuration;
        }


        /// <summary>
        /// Logar um Profissional
        /// </summary>
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> GetProfissionalLogin([FromBody] ProfissionalLoginRequestContract body)
        {
            try
            {
                var profissional = body.ConvertFromBody();
                var response = await _profissionalService.GetProfissionalLogin(profissional.Email, profissional.Senha);

                if (response == null)
                {
                    return BadRequest("Email ou senha inválidos");
                }

                var authenticationResponse = GenerateJwtToken(response);

                return Ok(new ProfissionalLoginResponseContract()
                {
                    Token = authenticationResponse,
                    Id = response.Id
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao fazer login");
                return BadRequest("Email ou senha Inválidos");
            }
        }

        /// <summary>
        /// Criar um Profissional
        /// </summary>
        [HttpPost]
        [Route("new")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateProfissional([FromBody] CreateProfissionalRequestContract body)
        {
            try
            {
                var profissional = body.ConvertFromBody();
                var response = await _profissionalService.CreateProfissional(profissional);

                if (!response)
                    throw new Exception("Erro ao tentar criar profissional");

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Atualizar um Profissional
        /// </summary>
        [HttpPut]
        [Route("update")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> UpdateProfissional([FromBody] UpdateProfissionalRequestContract body)
        {
            try
            {
                var profissional = body.ConvertFromBody();
                var response = await _profissionalService.UpdateProfissional(profissional);

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
        /// Eliminar um Profissional
        /// </summary>
        [HttpDelete]
        [Route("delete/{id}")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> DeleteProfissional([FromRoute(Name = "id")] int id)
        {
            try
            {
                var response = await _profissionalService.DeleteProfissional(id);

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
        /// Obter um Profissional
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> GetProfissional([FromRoute(Name = "id")] int id)
        {
            try
            {

                var profissional = await _profissionalService.GetProfissional(id);

                if (profissional == null)
                    throw new Exception("Profissional não pode ser nulo");

                return Ok(profissional);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Obter todos os profissionais
        /// </summary>
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> GetAllProfissionais()
        {
            try
            {
                var profissionais = await _profissionalService.GetAllProfissionais();

                if (profissionais == null)
                    throw new Exception("Erro ao tentar obter todos os profissionais");

                return Ok(profissionais);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private string GenerateJwtToken(Profissional profissional)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, profissional.Nome + profissional.Apelido),
                new Claim(ClaimTypes.Email, profissional.Email),
                new Claim(ClaimTypes.Role, "Profissional"),
            };

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims.ToArray(),
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
