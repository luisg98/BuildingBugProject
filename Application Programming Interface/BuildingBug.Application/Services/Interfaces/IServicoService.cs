using BuildingBug.Domain.Model;

namespace BuildingBug.Application.Services.Interfaces
{
    public interface IServicoService
    {
        public Task<Servico> GetServicoById(int id);

        public Task<bool> CreateServico(Servico servico);

        public Task<bool> UpdateServico(Servico servico);

        public Task<bool> DeleteServico(int id);

        public Task<bool> AceitarServico(int profissionalId, int id);

        public Task<IEnumerable<Servico>> GetAllServicos();

        public Task<IEnumerable<ServicoDTO>> GetAllServicosDeProfissional(int id);
        public Task<IEnumerable<ServicoDTO>> GetAllServicosDeCliente(int id);
        public Task<IEnumerable<ServicoDTO>> GetAllServicosParaProfissional();
    }
}