using GuitarStore.Portal.Domain.Entities;

namespace GuitarStore.Portal.Application.AppNewGuitar.Interface
{
    public interface IGuitarAppService
    {
        Task<Guitar> InsertAsync(Guitar newGuitar);
    }
}
