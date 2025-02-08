using GuitarStore.Portal.Domain.Entities;
using GuitarStore.Portal.Domain.Interfaces;
using Marraia.MongoDb.Repositories;
using Marraia.MongoDb.Repositories.Interfaces;

namespace GuitarStore.Portal.Infrastructure.Repositories.Repository
{
    public class GuitarRepository : MongoDbRepositoryStandard<Guitar, Guid>, IGuitarRepository
    {
        public GuitarRepository(IMongoContext context) : base(context) { }

        public async Task InsertAsync(Guitar newGuitar)
        {
            await Collection
                    .InsertOneAsync(newGuitar)
                    .ConfigureAwait(false);
        }

    }
}
