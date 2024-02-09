using BuildingBug.Domain.Model;

namespace BuildingBug.Test.FakeData
{
    public static class FakeProfissionalData
    {
        public static List<Profissional> GetAllProfissionais = new List<Profissional>()
        {
                new Profissional { Id = 1, Nome = "Luis", Apelido="Gonsalves"},
                new Profissional { Id = 2, Nome = "Rui", Apelido="Majalhaes" },
                new Profissional { Id = 3, Nome = "Santo", Apelido="Antonio" }
        };
    }
}
