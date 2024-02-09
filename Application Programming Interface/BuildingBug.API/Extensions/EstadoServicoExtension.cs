using BuildingBug.API.Data.Contracts.EstadoServico;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions.EstadosServico
{
    public static class EstadoServicoExtension
    {
        public static EstadoServico ConvertFromBody(this CreateEstadoServicoRequestContract newEstadoServico)
        {
            return new EstadoServico()
            {
                Descricao = newEstadoServico.Descricao,
            };
        }

        public static EstadoServico ConvertFromBody(this UpdateEstadoServicoRequestContract updateEstadoServico)
        {
            return new EstadoServico()
            {
                Id = updateEstadoServico.Id,
                Descricao = updateEstadoServico.Descricao
            };
        }
    }
}
