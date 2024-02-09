using BuildingBug.Domain.Model;

namespace BuildingBug.Test.FakeData
{
    public static class FakeDeslocacaoData
    {
        private static readonly Random random = new Random();

        public static List<Deslocacao> GetAllDeslocacoes = new List<Deslocacao>()
        {
            new Deslocacao { Id = 1, Data = GeraDataAleatoria() },
            new Deslocacao { Id = 2, Data = GeraDataAleatoria() },
            new Deslocacao { Id = 3, Data = GeraDataAleatoria() }
        };

        private static DateTime GeraDataAleatoria()
        {
            DateTime start = new DateTime(2020, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
    }
}
