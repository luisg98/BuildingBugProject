using BuildingBug.Infrastructure.Services;
using BuildingBug.Test.FakeData;
using BuildingBug.Test.Mock.Gateways;
using BuildingBug.Test.Mock.Loggers;
using BuildingBug.Test.Mock.Services;
using Moq;

namespace BuildingBug.Test.Tests.Services
{
    [TestClass]
    public class ClienteUnitTests
    {
        [TestMethod]
        public async Task TestGetAllClientes_ReturnsListOfClientes()
        {
            // Arrange
            var _logger = new MockClienteServiceLogger();
            var _clienteGateway = new MockClienteGateway();
            var _passwordService = new MockPasswordService();

            // Setup
            _clienteGateway.Setup(gateway => gateway.GetAllClientes()).ReturnsAsync(FakeClienteData.GetAllClientes);
            var _clienteService = new ClienteService(_logger.Object, _clienteGateway.Object, _passwordService.Object);

            var response = await _clienteService.GetAllClientes();
            var listaClientes = response.ToList();

            // Assert
            Assert.AreEqual(FakeClienteData.GetAllClientes.Count, listaClientes.Count);
            for (int i = 0; i < FakeClienteData.GetAllClientes.Count; i++)
            {
                Assert.AreEqual(FakeClienteData.GetAllClientes[i].Id, listaClientes[i].Id);
                Assert.AreEqual(FakeClienteData.GetAllClientes[i].Email, listaClientes[i].Email);
                Assert.AreEqual(FakeClienteData.GetAllClientes[i].Senha, listaClientes[i].Senha);
            }
        }

        [DataTestMethod]
        [DataRow(1, true)]
        [DataRow(2, true)]
        [DataRow(5, false)]
        public async Task GetCliente_DevolveClienteQuandoExiste(int clienteId, bool exist)
        {
            // Arrange
            var _logger = new MockClienteServiceLogger();
            var _passwordService = new MockPasswordService();
            var clienteGateway = new MockClienteGateway();

            // Setup
            clienteGateway.Setup(gateway => gateway.GetCliente(clienteId)).ReturnsAsync(FakeClienteData.GetAllClientes.FirstOrDefault(cliente => cliente.Id == clienteId));
            var clienteService = new ClienteService(_logger.Object, clienteGateway.Object, _passwordService.Object);

            var response = await clienteService.GetCliente(clienteId);

            // Assert
            if (exist)
                Assert.IsNotNull(response);
            else
                Assert.IsNull(response);
        }


        [DataTestMethod]
        [DataRow("NameDummy", "123")]
        public async Task GetClienteLogin_DevolveErroSeInvalido(string email, string senha)
        {
            // Arrange
            var _logger = new MockClienteServiceLogger();
            var _passwordService = new MockPasswordService();
            var clienteGateway = new MockClienteGateway();

            // Setup
            clienteGateway.Setup(gateway => gateway.GetClienteLogin(email)).ReturnsAsync(FakeClienteData.GetAllClientes.FirstOrDefault(cliente => cliente.Email == email));
            var clienteService = new ClienteService(_logger.Object, clienteGateway.Object, _passwordService.Object);

            await Assert.ThrowsExceptionAsync<Exception>(async () => await clienteService.GetClienteLogin(email, senha), "Erro de login");
        }


    }
}

