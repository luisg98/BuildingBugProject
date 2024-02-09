using BuildingBug.Domain.Model;

namespace BuildingBug.Test.FakeData
{
    public static class FakeTipoData
    {
        public static List<Tipo> GetAllTipos = new List<Tipo>()
        {
                new Tipo { Id = 1, Descricao = "Eletricista" },
                new Tipo { Id = 2, Descricao = "Canalizador" },
                new Tipo { Id = 3, Descricao = "Pintor" }
        };
    }
}
