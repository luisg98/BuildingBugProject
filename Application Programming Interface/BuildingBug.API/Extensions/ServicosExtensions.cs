using BuildingBug.API.Data.Contracts.Servicos;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions
{
    public static class ServicosExtensions
    {
        public static Servico ConvertFromBody(this CreateServicoRequestContract novoServico)
        {
            return new Servico()
            {
                Morada = novoServico.Morada,
                Fator = novoServico.Fator,
                ClienteId = novoServico.ClienteId,
                CodigoPostalCP = novoServico.CodigoPostalCP,
                TipoId = novoServico.TipoId


            };
        }

        public static Servico ConvertFromBody(this UpdateServicoRequestContract atualizarServico)
        {
            return new Servico()
            {
                Id = atualizarServico.Id,
                Morada = atualizarServico.Morada,
                DataInicio = atualizarServico.DataInicio,
                DataFim = atualizarServico.DataFim,
                Avaliacao = atualizarServico.Avaliacao,
                Custo = atualizarServico.Custo,
                Fator = atualizarServico.Fator,
                ClienteId = atualizarServico.ClienteId,
                EstadoServicoId = atualizarServico.EstadoServicoId,
                CodigoPostalCP = atualizarServico.CodigoPostalCP,
                ProfissionalId = atualizarServico.ProfissionalId,
                TipoId = atualizarServico.TipoId

            };
        }
    }
}
