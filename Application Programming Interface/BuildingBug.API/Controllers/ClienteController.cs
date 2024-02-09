using BuildingBug.API.Data.Contracts.Clientes;
using BuildingBug.API.Extensions;
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
    public class ClienteController : ApiBaseController
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClienteService _clienteService;
        private readonly IConfiguration _configuration;


        public ClienteController(ILogger<ClienteController> logger, IClienteService clienteService, IConfiguration configuration)
        {
            _logger = logger;
            _clienteService = clienteService;
            _configuration = configuration;
        }


        /// <summary>
        /// Logar um cliente.
        /// </summary>
        /// <returns>Token</returns>
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        
        public async Task<IActionResult> GetClienteLogin([FromBody] ClienteLoginRequestContract body)
        {
            try
            {
                var cliente = body.ConvertFromBody();
                var response = await _clienteService.GetClienteLogin(cliente.Email, cliente.Senha);

                if (response == null)
                {
                    return BadRequest("Email ou senha inválidos");
                }

                var authenticationResponse = GenerateJwtToken(response);

                return Ok(new ClienteLoginResponseContract()
                {
                    Token = authenticationResponse,
                    Id = response.Id
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao fazer login");
                return BadRequest("Ocorreu um erro ao fazer login");
            }
        }

        /// <summary>
        /// Criar um cliente.
        /// </summary>
        [AllowAnonymous]
        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> CreateCliente([FromBody] CreateClienteRequestContract body)
        {
            try
            {
                var cliente = body.ConvertFromBody();
                var response = await _clienteService.CreateCliente(cliente);

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
        /// Atualizar um cliente.
        /// </summary>
        [HttpPut]
        [Route("update")]
        [Authorize(Roles = "Cliente")]
        public async Task<IActionResult> UpdateCliente([FromBody] UpdateClienteRequestContract body)
        {
            try
            {
                var cliente = body.ConvertFromBody();
                var response = await _clienteService.UpdateCliente(cliente);

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
        /// Eliminar um cliente.
        /// </summary>
        [Authorize(Roles = "Cliente")]
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteCliente([FromRoute(Name = "id")] int id)
        {
            try
            {
                var response = await _clienteService.DeleteCliente(id);

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
        /// Obter um cliente.
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        //[Authorize(Roles = "Cliente")]
        public async Task<IActionResult> GetCliente([FromRoute(Name = "id")] int id)
        {
            try
            {


                var cliente = await _clienteService.GetCliente(id);

                if (cliente == null)
                    throw new Exception("Cliente não pode ser nulo (cliente não encontrado).");

                return Ok(new GetClienteResponseContract()
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Apelido = cliente.Apelido,
                    Email = cliente.Email,
                    Senha = cliente.Senha,
                    Contacto = cliente.Contacto,
                    Inactive = cliente.Inactive,

                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obter todos os clientes.
        /// </summary>
        /// <returns>lista de clientes</returns>
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllClientes()
        {
            try
            {
                var cliente = await _clienteService.GetAllClientes();

                if (cliente == null)
                    throw new Exception("Cliente não pode ser nulo (cliente não encontrado).");

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        private string GenerateJwtToken(Cliente cliente)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, cliente.Nome + cliente.Apelido),
                new Claim(ClaimTypes.Email, cliente.Email),
                new Claim(ClaimTypes.Role, "Cliente"),
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