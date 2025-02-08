using GuitarStore.Portal.Domain.Entities;

namespace GuitarStore.Portal.Domain.Interfaces
{
    public interface IGuitarRepository
    {
        Task InsertAsync(Guitar newGuitar);
    }
}
