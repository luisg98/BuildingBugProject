using BuildingBug.API.Data.Contracts.CodigosPostais;
using BuildingBug.Domain.Model;

namespace BuildingBug.API.Extensions.CodigosPostais
{
    public static class CodigoPostalExtension
    {
        public static CodigoPostal ConvertFromBody(this CreateCodigoPostalRequestContract newCodigoPostal)
        {
            return new CodigoPostal()
            {
                CP = newCodigoPostal.CP,
                Distrito = newCodigoPostal.Distrito
            };
        }

        public static CodigoPostal ConvertFromBody(this UpdateCodigoPostalRequestContract updateCodigoPostal)
        {
            return new CodigoPostal()
            {
                CP = updateCodigoPostal.CP,
                Distrito = updateCodigoPostal.Distrito
            };
        }
    }
}
