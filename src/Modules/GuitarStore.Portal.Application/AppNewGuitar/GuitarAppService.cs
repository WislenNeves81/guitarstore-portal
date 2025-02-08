using GuitarStore.Portal.Application.AppNewGuitar.Interface;
using GuitarStore.Portal.Domain.Entities;
using GuitarStore.Portal.Domain.Interfaces;

namespace GuitarStore.Portal.Application.AppNewGuitar
{
    public class GuitarAppService : IGuitarAppService
    {
        private readonly IGuitarRepository _newGuitarRepository;

        public GuitarAppService(IGuitarRepository newGuitarRepository)
        {
            _newGuitarRepository = newGuitarRepository;
        }

        public async Task<Guitar>InsertAsync(Guitar newGuitar)
        {
            await _newGuitarRepository
                    .InsertAsync(newGuitar)
                    .ConfigureAwait(false);

            return newGuitar;
        }
    }
}
