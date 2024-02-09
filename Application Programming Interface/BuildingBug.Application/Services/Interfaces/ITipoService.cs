using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface ITipoService
    {
        public Task<bool> CreateTipo(Tipo tipo);
        public Task<bool> UpdateTipo(Tipo tipo);
        public Task<bool> DeleteTipo(int id);
        public Task<Tipo> GetTipo(int id);
        public Task<IEnumerable<Tipo>> GetAllTipos();

        public Task<IEnumerable<Tipo>> GetAllTiposPorCategoria(string categoria);
    }
}
