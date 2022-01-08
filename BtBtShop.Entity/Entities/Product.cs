
namespace BtBtShop.Entity.Entities
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}