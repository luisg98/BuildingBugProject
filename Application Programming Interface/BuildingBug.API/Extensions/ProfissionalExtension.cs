using BuildingBug.API.Data.Contracts.Profissionais;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions.Profissionais
{
    public static class ProfissionalExtensions
    {
        public static Profissional ConvertFromBody(this CreateProfissionalRequestContract newProfissional)
        {
            return new Profissional()
            {
                Nome = newProfissional.Nome,
                Apelido = newProfissional.Apelido,
                Email = newProfissional.Email,
                Senha = newProfissional.Senha,
                Contacto = newProfissional.Contacto

            };
        }

        public static Profissional ConvertFromBody(this UpdateProfissionalRequestContract updateProfissional)
        {
            return new Profissional()
            {
                Id = updateProfissional.Id,
                Nome = updateProfissional.Nome,
                Apelido = updateProfissional.Apelido,
                Contacto = updateProfissional.Contacto

            };
        }

        public static Profissional ConvertFromBody(this ProfissionalLoginRequestContract profissionalLogin)
        {
            return new Profissional()
            {
                Email = profissionalLogin.Email,
                Senha = profissionalLogin.Password
            };
        }
    }
}