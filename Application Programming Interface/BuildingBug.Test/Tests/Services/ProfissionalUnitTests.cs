using BuildingBug.Infrastructure.Services;
using BuildingBug.Test.FakeData;
using BuildingBug.Test.Mock.Gateways;
using BuildingBug.Test.Mock.Loggers;
using BuildingBug.Test.Mock.Services;
using Moq;

namespace BuildingBug.Test.Tests.Services
{
    [TestClass]
    public class ProfissionalUnitTests
    {
        [TestMethod]
        public async Task TestGetAllProfissionais_ReturnsListOfProfissionais()
        {
            // Arrange
            var _logger = new MockProfissionalServiceLogger();
            var _profissionalGateway = new MockProfissionalGateway();
            var _passwordService = new MockPasswordService();

            // Setup
            _profissionalGateway.Setup(gateway => gateway.GetAllProfissionais()).ReturnsAsync(FakeProfissionalData.GetAllProfissionais);
            var _profissionalService = new ProfissionalService(_logger.Object, _profissionalGateway.Object, _passwordService.Object);

            var response = await _profissionalService.GetAllProfissionais();
            var listaProfissionais = response.ToList();

            // Assert
            Assert.AreEqual(FakeProfissionalData.GetAllProfissionais.Count, listaProfissionais.Count);
            for (int i = 0; i < FakeProfissionalData.GetAllProfissionais.Count; i++)
            {
                Assert.AreEqual(FakeProfissionalData.GetAllProfissionais[i].Id, listaProfissionais[i].Id);
                Assert.AreEqual(FakeProfissionalData.GetAllProfissionais[i].Nome, listaProfissionais[i].Nome);
                Assert.AreEqual(FakeProfissionalData.GetAllProfissionais[i].Apelido, listaProfissionais[i].Apelido);
            }
        }
    }
}

