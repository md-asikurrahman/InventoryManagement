

using InventoryManagement.Domain.BaseEntities;

namespace InventoryManagement.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string CO {  get; set; }
        public string RoadNo {  get; set; }
        public string HouseNo { get; set; }
        public string FullAddress {  get; set; }


    }
}
