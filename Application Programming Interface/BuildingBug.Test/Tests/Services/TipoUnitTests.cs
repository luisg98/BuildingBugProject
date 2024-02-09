using BuildingBug.Infrastructure.Services;
using BuildingBug.Test.FakeData;
using BuildingBug.Test.Mock.Gateways;
using BuildingBug.Test.Mock.Loggers;
using Moq;

namespace BuildingBug.Test.Tests.Services
{
    [TestClass]
    public class TipoUnitTests
    {
        [TestMethod]
        public async Task TestGetAllTipos_ReturnsListOfTipos()
        {
            // Arrange
            var _logger = new MockTipoServiceLogger();
            var _tipoGateway = new MockTipoGateway();

            // Setup
            _tipoGateway.Setup(gateway => gateway.GetAllTipos()).ReturnsAsync(FakeTipoData.GetAllTipos);
            var _tipoService = new TipoService(_logger.Object, _tipoGateway.Object);

            var response = await _tipoService.GetAllTipos();
            var listaTipos = response.ToList();

            // Assert
            Assert.AreEqual(FakeTipoData.GetAllTipos.Count, listaTipos.Count);
            for (int i = 0; i < FakeTipoData.GetAllTipos.Count; i++)
            {
                Assert.AreEqual(FakeTipoData.GetAllTipos[i].Id, listaTipos[i].Id);
                Assert.AreEqual(FakeTipoData.GetAllTipos[i].Descricao, listaTipos[i].Descricao);
            }
        }
    }
}

