using BuildingBug.Infrastructure.Services;
using BuildingBug.Test.FakeData;
using BuildingBug.Test.Mock.Gateways;
using BuildingBug.Test.Mock.Loggers;
using Moq;

namespace BuildingBug.Test.Tests.Services
{
    [TestClass]
    public class CodigoPostalUnitTests
    {
        [TestMethod]
        public async Task TestGetAllCodigosPostais_ReturnsListOfCodigosPostais()
        {
            // Arrange
            var _logger = new MockCodigoPostalServiceLogger();
            var _codigoPostalGateway = new MockCodigoPostalGateway();

            // Setup
            _codigoPostalGateway.Setup(gateway => gateway.GetAllCodigosPostais()).ReturnsAsync(FakeCodigoPostalData.GetAllCodigosPostais);
            var _codigoPostalService = new CodigoPostalService(_logger.Object, _codigoPostalGateway.Object);

            var response = await _codigoPostalService.GetAllCodigosPostais();
            var listaCodigosPostais = response.ToList();

            // Assert
            Assert.AreEqual(FakeCodigoPostalData.GetAllCodigosPostais.Count, listaCodigosPostais.Count);
            for (int i = 0; i < FakeCodigoPostalData.GetAllCodigosPostais.Count; i++)
            {
                Assert.AreEqual(FakeCodigoPostalData.GetAllCodigosPostais[i].CP, listaCodigosPostais[i].CP);
                Assert.AreEqual(FakeCodigoPostalData.GetAllCodigosPostais[i].Localidade, listaCodigosPostais[i].Localidade);
            }
        }
    }
}

