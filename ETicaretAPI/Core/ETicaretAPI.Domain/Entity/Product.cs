using ETicaretAPI.Domain.Entity.Common;

namespace ETicaretAPI.Domain.Entity
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public long Price{ get; set; }
    }
}
