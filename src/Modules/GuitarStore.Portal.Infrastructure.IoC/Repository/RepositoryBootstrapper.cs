using GuitarStore.Portal.Application.AppNewGuitar.Interface;
using GuitarStore.Portal.Domain.Interfaces;
using GuitarStore.Portal.Infrastructure.Repositories.Repository;
using Marraia.MongoDb.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GuitarStore.Portal.Infrastructure.IoC.Repository
{
    internal class RepositoryBootstrapper
    {
        internal void ChildServiceRegister(IServiceCollection service)
        {
            service.AddMongoDb();
            service.AddScoped<IGuitarRepository, GuitarRepository>();
        }
    }
}
