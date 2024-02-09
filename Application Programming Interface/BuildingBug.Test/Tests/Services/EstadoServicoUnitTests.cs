using BuildingBug.Infrastructure.Services;
using BuildingBug.Test.FakeData;
using BuildingBug.Test.Mock.Gateways;
using BuildingBug.Test.Mock.Loggers;
using Moq;

namespace BuildingBug.Test.Tests.Services
{
    [TestClass]
    public class EstadoServicoUnitTests
    {
        [TestMethod]
        public async Task TestGetAllEstadosServico_ReturnsListOfEstadosServicos()
        {
            // Arrange
            var _logger = new MockEstadoServicoServiceLogger();
            var _estadoServicoGateway = new MockEstadoServicoGateway();

            // Setup
            _estadoServicoGateway.Setup(gateway => gateway.GetAllEstadosServico()).ReturnsAsync(FakeEstadoServicoData.GetAllEstadosServico);
            var _estadoServicoService = new EstadoServicoService(_logger.Object, _estadoServicoGateway.Object);

            var response = await _estadoServicoService.GetAllEstadosServico();
            var listaEstadosServico = response.ToList();

            // Assert
            Assert.AreEqual(FakeEstadoServicoData.GetAllEstadosServico.Count, listaEstadosServico.Count);
            for (int i = 0; i < FakeEstadoServicoData.GetAllEstadosServico.Count; i++)
            {
                Assert.AreEqual(FakeEstadoServicoData.GetAllEstadosServico[i].Id, listaEstadosServico[i].Id);
                Assert.AreEqual(FakeEstadoServicoData.GetAllEstadosServico[i].Descricao, listaEstadosServico[i].Descricao);
            }
        }
    }
}

