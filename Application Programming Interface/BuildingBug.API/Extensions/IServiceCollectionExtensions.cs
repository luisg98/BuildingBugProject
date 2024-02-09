using BuildingBug.Application.Services.Interfaces;
using BuildingBug.Infrastructure.Gateways;
using BuildingBug.Infrastructure.Gateways.Interfaces;
using BuildingBug.Infrastructure.Services;

namespace BuildingBug.API.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddApiServices(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddHostedService<TaskBiddingService>();
            //serviceCollection.AddHostedService<CompanyResetJobsService>();

            serviceCollection.AddHttpClient<GetDistritoService>();
            serviceCollection.AddSingleton<IClienteGateway, ClienteGateway>();
            serviceCollection.AddSingleton<IClienteService, ClienteService>();
            serviceCollection.AddSingleton<IServicoGateway, ServicoGateway>();
            serviceCollection.AddSingleton<IServicoService, ServicoService>();
            serviceCollection.AddSingleton<ICodigoPostalGateway, CodigoPostalGateway>();
            serviceCollection.AddSingleton<ICodigoPostalService, CodigoPostalService>();
            serviceCollection.AddSingleton<IEstadoServicoGateway, EstadoServicoGateway>();
            serviceCollection.AddSingleton<IEstadoServicoService, EstadoServicoService>();
            serviceCollection.AddSingleton<IDeslocacaoGateway, DeslocacaoGateway>();
            serviceCollection.AddSingleton<IDeslocacaoService, DeslocacaoService>();
            serviceCollection.AddSingleton<IProfissionalGateway, ProfissionalGateway>();
            serviceCollection.AddSingleton<IProfissionalService, ProfissionalService>();
            serviceCollection.AddSingleton<ITipoGateway, TipoGateway>();
            serviceCollection.AddSingleton<ITipoService, TipoService>();
            serviceCollection.AddSingleton<ITipoProfissionalGateway, TipoProfissionalGateway>();
            serviceCollection.AddSingleton<ITipoProfissionalService, TipoProfissionalService>();
            serviceCollection.AddSingleton<IPasswordService, PasswordService>();
            //serviceCollection.AddSingleton<IEmailService, EmailService>();
        }
    }
}
