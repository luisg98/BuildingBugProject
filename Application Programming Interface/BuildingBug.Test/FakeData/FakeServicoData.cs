using BuildingBug.Domain.Model;

namespace BuildingBug.Test.FakeData
{
    public static class FakeServicoData
    {
        public static List<Servico> GetAllServicos = new List<Servico>()
        {
                new Servico { Id = 1, Morada = "Na minha casa, ia ser onde?", DataInicio= DateTime.Now  },
                new Servico { Id = 2, Morada = "Quem vai e vira", DataInicio= DateTime.Now },
                new Servico { Id = 3, Morada = "Rua!", DataInicio= DateTime.Now}
        };
    }
}
