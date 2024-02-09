using BuildingBug.API.Data.Contracts.Tipos;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions.Tipos

{
    public static class TipoExtension
    {
        public static Tipo ConvertFromBody(this CreateTipoRequestContract newTipo)
        {
            return new Tipo()
            {
                Descricao = newTipo.Descricao,
                Preco = newTipo.Preco,
                Fator = newTipo.Fator,
                Categoria = newTipo.Categoria
            };
        }

        public static Tipo ConvertFromBody(this UpdateTipoRequestContract updateTipo)
        {
            return new Tipo()
            {
                Id = updateTipo.Id,
                Descricao = updateTipo.Descricao,
                Preco = updateTipo.Preco,
                Fator = updateTipo.Fator,
                Categoria = updateTipo.Categoria

            };
        }
    }
}
