using BuildingBug.Domain.Model;

namespace BuildingBug.Test.FakeData
{
    public static class FakeEstadoServicoData
    {
        public static List<EstadoServico> GetAllEstadosServico = new List<EstadoServico>()
        {
                new EstadoServico { Id = 1, Descricao = "Pedido" },
                new EstadoServico { Id = 2, Descricao = "Em execução" },
                new EstadoServico { Id = 3, Descricao = "Finalizado" }
        };
    }
}
