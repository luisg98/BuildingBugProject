using BuildingBug.API.Data.Contracts.Clientes;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions
{
    public static class ClientesExtensions
    {
        public static Cliente ConvertFromBody(this CreateClienteRequestContract newCliente)
        {
            return new Cliente()
            {
                Nome = newCliente.Nome,
                Apelido = newCliente.Apelido,
                Senha = newCliente.Senha,
                Email = newCliente.Email,
                Contacto = newCliente.Contacto,

            };
        }

        public static Cliente ConvertFromBody(this UpdateClienteRequestContract updateCliente)
        {
            return new Cliente()
            {
                Id = updateCliente.Id,
                Nome = updateCliente.Nome,
                Apelido = updateCliente.Apelido,
                Contacto = updateCliente.Contacto


            };
        }

        public static Cliente ConvertFromBody(this ClienteLoginRequestContract clienteLogin)
        {
            return new Cliente()
            {
                Email = clienteLogin.Email,
                Senha = clienteLogin.Password
            };
        }
    }
}