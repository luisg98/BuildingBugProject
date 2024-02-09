using BuildingBug.Domain.Model;

namespace BuildingBug.Test.FakeData
{
    public static class FakeCodigoPostalData
    {
        public static List<CodigoPostal> GetAllCodigosPostais = new List<CodigoPostal>()
        {
                new CodigoPostal { CP = 4710404, Localidade = "São Vitor, Braga" },
                new CodigoPostal { CP = 4830825, Localidade = "Vilela, Póvoa de Lanhoso" },
                new CodigoPostal { CP = 4750810, Localidade = "Barcelos" }
        };
    }
}
