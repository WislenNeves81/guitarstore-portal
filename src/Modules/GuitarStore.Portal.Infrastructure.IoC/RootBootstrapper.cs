using GuitarStore.Portal.Infrastructure.IoC.Application;
using GuitarStore.Portal.Infrastructure.IoC.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GuitarStore.Portal.Infrastructure.IoC
{
    public class RootBootstrapper
    {
        public void BootstrapperRegisterServices(IServiceCollection services)
        {
            new RepositoryBootstrapper().ChildServiceRegister(services);
            new ApplicationBootstrapper().ChildServiceRegister(services);
        }
    }
}
