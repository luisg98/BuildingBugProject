using BuildingBug.API.Data.Contracts.Deslocacoes;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions.Deslocacoes
{
    public static class DeslocacoesExtension
    {
        public static Deslocacao ConvertFromBody(this CreateDeslocacaoRequestContract newDeslocacao)
        {
            return new Deslocacao()
            {
                Data = newDeslocacao.Data,
                ServicoId = newDeslocacao.ServicoId,
                Detalhes = newDeslocacao.Detalhes

            };
        }

        public static Deslocacao ConvertFromBody(this UpdateDeslocacaoRequestContract updateDeslocacao)
        {
            return new Deslocacao()
            {
                Id = updateDeslocacao.Id,
                Data = updateDeslocacao.Data,
                ServicoId = updateDeslocacao.ServicoId,
                Detalhes = updateDeslocacao.Detalhes

            };
        }
    }
}
