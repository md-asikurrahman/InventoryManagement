using InventoryManagement.Domain.BaseEntities;

namespace InventoryManagement.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Brandname { get; set; }
        public string Branddescription { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
