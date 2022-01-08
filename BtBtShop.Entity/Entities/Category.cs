using System.Collections.Generic;

namespace BtBtShop.Entity.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}