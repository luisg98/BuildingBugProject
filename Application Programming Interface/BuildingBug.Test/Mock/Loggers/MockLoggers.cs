using BuildingBug.Infrastructure.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace BuildingBug.Test.Mock.Loggers
{

    public class MockCodigoPostalServiceLogger : Mock<ILogger<CodigoPostalService>>
    {
    }


    public class MockDeslocacaoServiceLogger : Mock<ILogger<DeslocacaoService>>
    {
    }
    public class MockEstadoServicoServiceLogger : Mock<ILogger<EstadoServicoService>>
    {
    }

    public class MockProfissionalServiceLogger : Mock<ILogger<ProfissionalService>>
    {
    }

    public class MockServicoServiceLogger : Mock<ILogger<ServicoService>>
    {
    }

    public class MockTipoServiceLogger : Mock<ILogger<TipoService>>
    {
    }
    public class MockClienteServiceLogger : Mock<ILogger<ClienteService>>
    {
    }

}

