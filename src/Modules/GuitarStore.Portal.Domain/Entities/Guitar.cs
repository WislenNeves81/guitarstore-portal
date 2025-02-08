using Marraia.MongoDb.Core;
using System.Reflection.Metadata;

namespace GuitarStore.Portal.Domain.Entities
{
    public class Guitar : Entity<Guid>
    {
        public string Branch { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public int Year { get; set; }
        public int NumberString { get; set; }
    }
}
