using BuildingBug.API.Data.Contracts.TiposProfissional;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions.TiposProfissional

{
    public static class TipoProfissionalExtension
    {
        public static TipoProfissional ConvertFromBody(this CreateTipoProfissionalRequestContract newTipoProfissional)
        {
            return new TipoProfissional()
            {
                TipoId = newTipoProfissional.TipoId,
                ProfissionalId = newTipoProfissional.ProfissionalId
            };
        }

        public static TipoProfissional ConvertFromBody(this UpdateTipoProfissionalRequestContract updateTipoProfissional)
        {
            return new TipoProfissional()
            {
                TipoId = updateTipoProfissional.TipoId,
                ProfissionalId = updateTipoProfissional.ProfissionalId
            };
        }
    }
}
