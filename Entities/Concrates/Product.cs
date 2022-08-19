using Entities.Abstarcts;

namespace Entities.Concrates
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }

    }
}
