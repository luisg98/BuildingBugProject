using BuildingBug.Infrastructure.Services;
using BuildingBug.Test.FakeData;
using BuildingBug.Test.Mock.Gateways;
using BuildingBug.Test.Mock.Loggers;
using Moq;

namespace BuildingBug.Test.Tests.Services
{
    [TestClass]
    public class DeslocacaoUnitTests
    {
        [TestMethod]
        public async Task TestGetAllDeslocacoes_ReturnsListOfDeslocacoes()
        {
            // Arrange
            var _logger = new MockDeslocacaoServiceLogger();
            var _deslocacaoGateway = new MockDeslocacaoGateway();

            // Setup
            _deslocacaoGateway.Setup(gateway => gateway.GetAllDeslocacoes()).ReturnsAsync(FakeDeslocacaoData.GetAllDeslocacoes);
            var _deslocacaoService = new DeslocacaoService(_logger.Object, _deslocacaoGateway.Object);

            var response = await _deslocacaoService.GetAllDeslocacoes();
            var listaDeslocacoes = response.ToList();

            // Assert
            Assert.AreEqual(FakeDeslocacaoData.GetAllDeslocacoes.Count, listaDeslocacoes.Count);
            for (int i = 0; i < FakeDeslocacaoData.GetAllDeslocacoes.Count; i++)
            {
                Assert.AreEqual(FakeDeslocacaoData.GetAllDeslocacoes[i].Id, listaDeslocacoes[i].Id);
                Assert.AreEqual(FakeDeslocacaoData.GetAllDeslocacoes[i].Data, listaDeslocacoes[i].Data);
            }
        }
    }
}

