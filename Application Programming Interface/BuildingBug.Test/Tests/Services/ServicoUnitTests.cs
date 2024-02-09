using BuildingBug.Infrastructure.Services;
using BuildingBug.Test.FakeData;
using BuildingBug.Test.Mock.Gateways;
using BuildingBug.Test.Mock.Loggers;
using Moq;

namespace BuildingBug.Test.Tests.Services
{
    [TestClass]
    public class ServicoUnitTests
    {
        [TestMethod]
        public async Task TestGetAllServicos_ReturnsListOfServicos()
        {
            // Arrange
            var _logger = new MockServicoServiceLogger();
            var _servicoGateway = new MockServicoGateway();

            // Setup
            _servicoGateway.Setup(gateway => gateway.GetAllServicos()).ReturnsAsync(FakeServicoData.GetAllServicos);
            var _servicoService = new ServicoService(_logger.Object, _servicoGateway.Object);

            var response = await _servicoService.GetAllServicos();
            var listaServicos = response.ToList();

            // Assert
            Assert.AreEqual(FakeServicoData.GetAllServicos.Count, listaServicos.Count);
            for (int i = 0; i < FakeServicoData.GetAllServicos.Count; i++)
            {
                Assert.AreEqual(FakeServicoData.GetAllServicos[i].Id, listaServicos[i].Id);
                Assert.AreEqual(FakeServicoData.GetAllServicos[i].Morada, listaServicos[i].Morada);
                Assert.AreEqual(FakeServicoData.GetAllServicos[i].DataInicio, listaServicos[i].DataInicio);
            }
        }

        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(1, true)]
        public async Task GetServico_DevolveServicoQuandoExiste(int servicoId, bool exist)
        {
            // Arrange
            var _logger = new MockServicoServiceLogger();
            var servicoGateway = new MockServicoGateway();

            // Setup
            servicoGateway.Setup(gateway => gateway.GetServicoById(servicoId)).ReturnsAsync(FakeServicoData.GetAllServicos.FirstOrDefault(servico => servico.Id == servicoId));
            var servicoService = new ServicoService(_logger.Object, servicoGateway.Object);

            var response = await servicoService.GetServicoById(servicoId);

            // Assert
            if (exist)
                Assert.IsNotNull(response);
            else
                Assert.IsNull(response);
        }
    }
}

