using InventoryManagement.Domain.BaseEntities;
using InventoryManagement.Domain.Enums;

namespace InventoryManagement.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string CO {  get; set; }
        public string RoadNo {  get; set; }
        public string HouseNo { get; set; }
        public string FullAddress {  get; set; }
        public AddressType AddressType { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } 
    }
}
