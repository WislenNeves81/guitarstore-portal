using GuitarStore.Portal.Application.AppNewGuitar;
using GuitarStore.Portal.Application.AppNewGuitar.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GuitarStore.Portal.Infrastructure.IoC.Application
{
    internal class ApplicationBootstrapper
    {
        internal void ChildServiceRegister(IServiceCollection service)
        {
            service.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            service.AddScoped<IGuitarAppService, GuitarAppService>();
        }
    }
}
