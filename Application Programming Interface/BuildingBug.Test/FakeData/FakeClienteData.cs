using BuildingBug.Domain.Model;

namespace BuildingBug.Test.FakeData
{
    public static class FakeClienteData
    {
        public static List<Cliente> GetAllClientes = new List<Cliente>()
        {
                new Cliente { Id = 1, Email = "a18851", Senha= "Trubin" },
                new Cliente { Id = 2, Email = "a22300", Senha= "DiogoCosta"},
                new Cliente { Id = 3, Email = "professores@ipca.pt", Senha = "Adan" }
        };
    }
}
